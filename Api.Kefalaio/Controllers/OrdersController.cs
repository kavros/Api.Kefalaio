using System;
using System.Collections.Generic;
using System.Linq;
using Api.Kefalaio.Controllers.Order;
using Api.Kefalaio.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api.Kefalaio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {

        private readonly KefalaioContext _dbContext;
        public OrdersController(KefalaioContext context)
        {
            _dbContext = context;
        }
       
        [HttpPost]
        [Route("GetOrder")]

        public IActionResult GetOrder(OrderParams orderParams)
        {

            var data = GetData(orderParams);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetSuppliers")]
        public IActionResult GetSuppliers()
        {
            var suppliers = _dbContext.Pmasts
                .OrderBy(x=>x.PName)
                .Select(x => new Supplier{ Name = x.PName, Code = x.PCode });
            return Ok(suppliers);
        }

        private IList<Item> GetData(OrderParams orderParams)
        {
            int nextOrderAfter = orderParams.NextOrderAfter;
            string suplierCode = orderParams.SupplierCode;
            int strnDateWindow = orderParams.DateWindow;

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
                              where s.StTransKind == 37 && s.StDate >= DateTime.Now.AddDays(-strnDateWindow)
                              group new { s, sm } by sm.SName into g
                              select new
                              {
                                sname = g.Key,
                                mesos_oros_ana_mera = g.Sum(x => x.s.StQuant) / strnDateWindow,
                              };
            var query = from supProd in allProducts.ToList()
                        join sales in salesTrans.ToList() on supProd.SName equals sales.sname
                        orderby supProd.SName descending
                        select new
                        {
                            Product = supProd.SName,
                            Stock = supProd.SstRemain1,
                            AvgSalesPerDay = sales.mesos_oros_ana_mera,
                        };

            var results = query.ToList().Select(x => new Item()
            {
                AvgSalesPerDay = (double) Math.Round((decimal)x.AvgSalesPerDay,2),
                Stock = (int) x.Stock,
                Product = x.Product,
                SuggestedQuantity = (int)Math.Round((decimal)x.AvgSalesPerDay*nextOrderAfter)
            }).ToList();
            return results;
        }
    }

}

/**
 * TODO:
 * refactor LINQ query so it extracts data from db. Apply bussiness logic like suggested quantity calculation later.
 * hide perivalontiko telos
 * use async
 * rename kefalaio controller to OrdersController
 * create service
 * should I close EF context? 
 * rename controller
 */