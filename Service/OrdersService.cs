using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Xml.Linq;

namespace Services
{
    public partial class OrdersService : IOrdersService
    {
        private readonly KefalaioContext _dbContext;
        private readonly string _connectionStringOld;
        public OrdersService(KefalaioContext context, IOptions<Configuration> configuration) {
            _dbContext = context;
            _connectionStringOld = configuration.Value.ConnectionStringOld;
        }
        public async Task AddToFailures(List<MyDataFailedImports> rows)
        {
            await _dbContext.AddRangeAsync(rows);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<IList<Product>> GetAllProducts()
        {
            var f =  await _dbContext.FailedImports.Select(x=> x.SCode).ToListAsync();

            return (from sm in _dbContext.Smasts
                    join vat in _dbContext.Vats on sm.SVatcode equals vat.FpaCode
                    join strn in _dbContext.Strns on sm.SFileId equals strn.SFileId
                    where f.Contains(sm.SCode)
                                    select new Product
                                    {
                                        SCode = sm.SCode,
                                        SName = sm.SName,
                                        Vat = vat.FpaData != null ? vat.FpaData.ToString() : string.Empty,
                                        Unit = sm.SUnitOm 
                                    }).Distinct().ToList();
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
            var windowFirstDate = DateTime.Now.AddDays((-1) * orderParams.DateWindow);
            using KefalaioContext oldContext = GetOldkefalaioContext();

            //get all products bought last three months for given supplier code
            var numberOfMonthsBack = 3;
            var minDate = DateTime.UtcNow.AddMonths(-numberOfMonthsBack);
            List<Product> productsBoughtThisYear = new();
            List<Product> productsBoughtLastYear = new();
            if (minDate.Year < DateTime.UtcNow.Year)
            {
                productsBoughtLastYear = await 
                    GetAllProducts(oldContext, suplierCode, minDate)
                    .ToListAsync();
            }
            productsBoughtThisYear = await
                    GetAllProducts(_dbContext, suplierCode, minDate)
                    .ToListAsync();
            var allProducts = productsBoughtThisYear
                .Concat(productsBoughtLastYear)
                .GroupBy(x => x.SName)
                .Select(x => new Product { SName = x.Key, SstRemain1 = GetSstRemain1(x.Key) ?? 0 }).ToList();

            //concat sales lists and sum sales ammount
            var includePreviousYear = windowFirstDate.Year < DateTime.UtcNow.Year;
            var previousYearSales = includePreviousYear
                ? await GetAllSales(oldContext, windowFirstDate).ToListAsync()
                : new List<Sale>();
            var lastYearSales = await GetAllSales(_dbContext, windowFirstDate).ToListAsync();
            var salesTrans = lastYearSales
                            .Concat(previousYearSales)
                            .GroupBy(x => x.SName)
                            .Select(x => new Sale { SName = x.Key, SumSales = x.Sum(i => i.SumSales) });

            var order =
                    from supProd in allProducts
                    join sales in salesTrans on supProd.SName equals sales.SName into ps_jointable
                    from p in ps_jointable.DefaultIfEmpty()
                    orderby supProd.SName descending
                    select new
                    {
                        Product = supProd.SName,
                        Stock = supProd.SstRemain1,
                        AvgSalesPerDay =  p!=null ?p.SumSales / orderParams.DateWindow : 0,
                    };


            var finalOrder = order
                .Select(x => new Item()
                {
                    AvgSalesPerDay = (double)Math.Round((decimal)(x.AvgSalesPerDay ?? 0), 2),
                    Stock = (int)(x.Stock ?? 0),
                    Product = x.Product,
                    SuggestedQuantity = (int)Math.Round((decimal)(x.AvgSalesPerDay ?? 0) * nextOrderAfter)
                }).ToList();
            return finalOrder;
        }

        private double? GetSstRemain1(string sname)
        {
            return (from sm in _dbContext.Smasts 
                    join st in _dbContext.Sstores on sm.SFileId equals st.SFileId
                    where st.SpaFileIdNo == 1 && sm.SName == sname
                    select st.SstRemain1).FirstOrDefault();
        }

        private KefalaioContext GetOldkefalaioContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<KefalaioContext>();
            optionsBuilder.UseSqlServer(_connectionStringOld);
            var oldContext = new KefalaioContext(optionsBuilder.Options);
            return oldContext;
        }
        private IQueryable<Product> GetAllProducts(KefalaioContext context, string suplierCode, DateTime minDate)
        {
            return  from b in context.Bmast1s
                    join s in context.Strns on b.PdFileId equals s.StBm1origin
                    join sm in context.Smasts on s.SFileId equals sm.SFileId
                    join st in context.Sstores on s.SFileId equals st.SFileId
                    join p in context.Pmasts on b.PFileId equals p.PFileId
                    where p.PCode == suplierCode && st.SpaFileIdNo == 1 && s.StDate > minDate
                    group new { sm.SName, st.SstRemain1 } by new { sm.SName, st.SstRemain1 } into g
                    select new Product
                    {
                        SName = g.Key.SName,
                        SstRemain1 = g.Key.SstRemain1
                    };
        }

        
        private IQueryable<Sale> GetAllSales(KefalaioContext context, DateTime windowFirstDate)
        {
            return  from s in context.Strns
                    join sm in context.Smasts on s.SFileId equals sm.SFileId
                    where s.StTransKind == 37 && s.StDate >= windowFirstDate
                    group new { s, sm } by sm.SName into g
                    select new Sale
                    {
                        SName = g.Key,
                        SumSales = g.Sum(x => x.s.StQuant)
                    };
        }
        
    }
}
