﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
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
        private readonly IMyDataService _myDataService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public OrdersController(IOrdersService ordersService, IMyDataService myDataService, IWebHostEnvironment webHostEnvironment)
        {
            _ordersService = ordersService;
            _myDataService = myDataService;
            _webHostEnvironment = webHostEnvironment;
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

        [HttpPost]
        [Route("SendInvoice")]
        public async Task<IActionResult> SendInvoice()
        {
            await _myDataService.SendInvoice();
            return Ok();
        }

    }

}

/**
 * TODO:
 * ! use correct appSettings.json based on the environment
 * 
 * hide perivalontiko telos
 * remove unused nuget packages like Serilog.Sinks.RollingFile
 */