using Data;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class OrdersService : IOrdersService
    {
        private readonly KefalaioContext _dbContext;
        public OrdersService(KefalaioContext context) {
            _dbContext = context;
        }

        public async Task<IList<Supplier>> GetSuppliers()
        {
            return await _dbContext.Pmasts
                            .OrderBy(x => x.PName)
                            .Select(x => new Supplier { Name = x.PName, Code = x.PCode })
                            .ToListAsync();
        }


        public async Task<IList<Item>> GetOrder(OrderParams orderParams)
        {
            int nextOrderAfter = orderParams.NextOrderAfter;
            string suplierCode = orderParams.SupplierCode;            
            var windowFirstDate = DateTime.Now.AddDays((-1)*orderParams.DateWindow);

            var allProducts = from b in _dbContext.Bmast1s
                              join s in _dbContext.Strns on b.PdFileId equals s.StBm1origin
                              join sm in _dbContext.Smasts on s.SFileId equals sm.SFileId
                              join st in _dbContext.Sstores on s.SFileId equals st.SFileId
                              join p in _dbContext.Pmasts on b.PFileId equals p.PFileId
                              where p.PCode == suplierCode && st.SpaFileIdNo == 1
                              group new { sm.SName, st.SstRemain1 } by new { sm.SName, st.SstRemain1 } into g
                              select new
                              {
                                  g.Key.SName,
                                  g.Key.SstRemain1
                              };
            var salesTrans = from s in _dbContext.Strns
                             join sm in _dbContext.Smasts on s.SFileId equals sm.SFileId
                             where s.StTransKind == 37 && s.StDate >= windowFirstDate
                             group new { s, sm } by sm.SName into g
                             select new
                             {
                                 sname = g.Key,
                                 mesos_oros_ana_mera = g.Sum(x => x.s.StQuant) / orderParams.DateWindow,
                             };

            var order = await
                (
                        from supProd in allProducts
                        join sales in salesTrans on supProd.SName equals sales.sname
                        orderby supProd.SName descending
                        select new
                        {
                            Product = supProd.SName,
                            Stock = supProd.SstRemain1,
                            AvgSalesPerDay = sales.mesos_oros_ana_mera,
                        }
                ).ToListAsync();

            var finalOrder = order
                .Select(x => new Item()
                {
                    AvgSalesPerDay = (double)Math.Round((decimal)(x.AvgSalesPerDay??0), 2),
                    Stock = (int)(x.Stock??0),
                    Product = x.Product,
                    SuggestedQuantity = (int)Math.Round((decimal)(x.AvgSalesPerDay??0) * nextOrderAfter)
                }).ToList();
            return finalOrder;
        }
    }
}
