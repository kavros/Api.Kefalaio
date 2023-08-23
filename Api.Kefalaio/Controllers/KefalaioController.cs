using System;
using System.Collections.Generic;
using System.Linq;
using Api.Kefalaio.Controllers.Order;
using Api.Kefalaio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Api.Kefalaio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KefalaioController : ControllerBase
    {

        private readonly ILogger<KefalaioController> _logger;
        private readonly KefalaioContext _dbContext;
        public KefalaioController(ILogger<KefalaioController> logger, KefalaioContext context)
        {
            _logger = logger;
            _dbContext = context;
        }

        [HttpGet]
        [Route("GetProducts")]
        public IEnumerable<Smast> GetProducts([FromQuery(Name = "sCodes")] string[] sCodes)
        {
            var products = _dbContext.Smasts
                        .Where(x => sCodes.Contains(x.SCode)).ToList();
            return products;
        }

        [HttpPatch]
        [Route("UpdateRetailPrice")]
        public void UpdatePrices(Smast[] products)
        {
            foreach (var item in products)
            {
                var product = _dbContext.Smasts.FirstOrDefault(x => item.SCode == x.SCode);
                if (product != null)
                {
                    product.SRetailPr = item.SRetailPr;
                }
            }

            _dbContext.SaveChanges();
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
                .Select(x => new { x.PName, x.PCode });
            return Ok(suppliers);
        }

        private IList<OrderResponse> GetData(OrderParams orderParams)
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
            //Console.WriteLine(allProducts.Count());
            var salesTrns = from s in _dbContext.Strns
                              join sm in _dbContext.Smasts on s.SFileId equals sm.SFileId
                              where s.StTransKind == 37 /*&& s.StDate >= DateTime.Now.AddDays(-strnDateWindow)*/
                              group new { s, sm } by sm.SName into g
                              select new
                              {
                                sname = g.Key,
                                mesos_oros_ana_mera = g.Sum(x => x.s.StQuant) / strnDateWindow,
                                protinomeni_posotita = nextOrderAfter * (g.Sum(x => x.s.StQuant) / strnDateWindow)
                              };
            //Console.WriteLine(salesTrns.Count());
            var query = from supProd in (
                allProducts
                        )
            join sales in (
                            salesTrns
                        ) on supProd.SName equals sales.sname
                        orderby supProd.SName descending
                        select new
                        {
                            Product = supProd.SName,
                            Quantity = supProd.SstRemain1,
                            AvgSalesPerDay = sales.mesos_oros_ana_mera,
                            SuggestedQuantity = sales.protinomeni_posotita
                        };

            var results = query.Select(x => new OrderResponse()
            {
                AvgSalesPerDay = x.AvgSalesPerDay,
                Quantity = x.Quantity,
                Product = x.Product,
                SuggestedQuantity = x.SuggestedQuantity

            }).ToList();
            return results;
        }
    }

}

/**
 * TODO
 * use async
 * rename kefalaio controller to OrdersController
 * create service
 * should I close EF context? 
 * rename controller
 * strnDateWindow code is commented (need to restore using latest db data)
 */