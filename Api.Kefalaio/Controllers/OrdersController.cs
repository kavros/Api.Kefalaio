using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serilog;
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

            try
            {
                var data = await _ordersService.GetOrder(orderParams);
                return Ok(data);
            }
            catch (Exception ex)
            {
                Log.Logger.Error($"Error: GetOrder request failed. \n {ex}");
                throw;
            }
        }

        [HttpGet]
        [Route("GetSuppliers")]
        public async Task<IActionResult> GetSuppliers()
        {
            try
            {
                var suppliers = await _ordersService.GetSuppliers();
                return Ok(suppliers);
            }
            catch (Exception ex)
            {
                Log.Logger.Error($"Error: GetSuppliers request failed. \n {ex}");
                throw;
            }
        }

    }

}

/**
 * TODO:
 * hide perivalontiko telos
 * remove unused nuget packages like Serilog.Sinks.RollingFile
 */