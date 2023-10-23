using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Api.Kefalaio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {

        private readonly IOrdersService _ordersService;
        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }
       
        [HttpPost]
        [Route("GetOrder")]

        public async Task<IActionResult> GetOrderAsync(OrderParams orderParams)
        {

            var data = await _ordersService.GetOrder(orderParams);
            return Ok(data);
        }

        [HttpGet]
        [Route("GetSuppliers")]
        public async Task<IActionResult> GetSuppliers()
        {
            var suppliers = await _ordersService.GetSuppliers();
            return Ok(suppliers);
        }

    }

}

/**
 * TODO:
 * hide perivalontiko telos
 * should I close EF context? 
 * rename controller
 */