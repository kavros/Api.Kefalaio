using System;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<Model.Smast> GetProducts(CodesDTO val)
        {
            var context = new Model.KefalaioContext();
            var products = context.Smasts
                        .Where(x=> val.sCodes.Contains(x.SCode)).ToList();
            return products;
        }
    }
}