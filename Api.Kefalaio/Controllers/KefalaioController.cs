using System;
using System.Collections.Generic;
using System.Linq;
using Api.Kefalaio.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Kefalaio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KefalaioController : ControllerBase
    {

        private readonly ILogger<KefalaioController> _logger;

        public KefalaioController(ILogger<KefalaioController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetProducts")]
        public IEnumerable<Smast> GetProducts([FromQuery(Name = "sCodes")] string[] sCodes)
        {
            var context = new KefalaioContext(); //TODO: interface ?
            var products = context.Smasts
                        .Where(x => sCodes.Contains(x.SCode)).ToList();
            return products;
        }

        [HttpPatch]
        [Route("UpdateRetailPrice")]
        public void UpdatePrices(Smast[] products)
        {
            var context = new KefalaioContext();
            foreach (var item in products)
            {
                var product = context.Smasts.FirstOrDefault(x => item.SCode == x.SCode);
                if (product != null)
                {
                    product.SRetailPr = item.SRetailPr;
                }
            }

            context.SaveChanges();
        }
    }

}