using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Services;
using System.Net.Http.Headers;
using System.Text;
using System.Collections.Generic;
using Amazon.Runtime.Internal.Transform;
using System.Linq;
using System.Text.Json;
using System.Web;
using Data;

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

    
        [HttpPost]
        [Route("ImportToMydata")]
        public async Task<IActionResult> ImportToMydata()
        {
            var products = (await _ordersService.GetAllProducts());
            var failedImports = new List<MyDataFailedImports>();
            var i = 0;
            ResponseStatus response = null;
            foreach (var product in products)
            {
                try
                {
                        response= await AddProductToMyData(product.SName, product.SCode, product.Unit, product.Vat);
                        if (!response.IsSuccess)
                        {
                            var item = new MyDataFailedImports()
                            {
                                Response = response.Message,
                                SCode = product.SCode,
                                SName = product.SName,
                            };
                            failedImports.Add(item);
                            //Console.WriteLine(product.SName + "----" + product.SCode  + "----" +item.Response); ;
                        }
                        Console.WriteLine(i);
                }
                catch (Exception ex)
                {
                        Console.WriteLine(products[i].SName);
                        Console.WriteLine(ex.Message);
                        var item = new MyDataFailedImports()
                        {
                            Response = response != null ? response?.Message: string.Empty,
                            SCode = product.SCode,
                            SName = product.SName,
                        };
                        failedImports.Add(item);

                }
                i++;
            }

            await _ordersService.AddToFailures(failedImports);
            return Ok();
        }

        class MyDataResponse
        {
            public bool success { get;set; }
            public string message { get;set; }

        }

        class ResponseStatus
        {
            public string Message { get; set; }
            public bool IsSuccess { get; set; }
        }
        private async Task<ResponseStatus> AddProductToMyData(string name, string code, string unit, string vat)
        {
            code = code.Replace("/", "-");
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://mydata.aade.gr/timologio/Product/create");

            request.Headers.Add("Accept", "*/*");
            request.Headers.Add("Accept-Language", "el-GR,el;q=0.9,en;q=0.8");
            request.Headers.Add("Connection", "keep-alive");
            request.Headers.Add("Cookie", ".AspNetCore.Antiforgery.9fXoN5jHCXs=CfDJ8NX9k-ZQHbNFpdtcPGJPqqUcdQaQvh1UyRdF2C78CbqhIVAWSoXBKyEsT1hPDU2axJMUaH_zX2vgkE390VuS0pJfJTOuzPHHYIOgh6ZPOPZcT4DR-pME1iTMGnFvS5qPLNVKnH5tnTEv15eF4mKqg1k; .AspNetCore.Identity.Application=CfDJ8NX9k-ZQHbNFpdtcPGJPqqVp61rhkfuT7wB6EfWotyye13zRewjyZ7yBpYUu9I5mmqLAdlEsMP3_IpXYCI7KAyoVruB3F-MiJIxxT55p3biqcb6ioWUEY2uj8xGurHCGQmCuLGLqhOX1I6Jp5r-YVTrZFi7PVlr5w4K8gKxCIbrfSkDO4PuDBy8IW8AkJCtpXTGlWJ7U-3AUJFfrGi0Oa6EoaTRP4ZNFs13vyGnYDvZyBOFiFt7i8jcUHqXTA6mJnK-RxkRsRuFKdy-TQaScyqkd9F14FH3-X1N3RUc4yH-L-815RuTYQdNLSjF0BcQnLIdHptSzfcj8KruuQgsLV5zyo5d-jQvFzEJZ3fEBRsvHuMxEZCNtfI7HY-K9GL1mL686yfMMk_aEmD3xeafZ0ajPsuEcJZwtJQ4GEa05KoH5QHmKJXmTjflmqHbuBn4EUH-cLi-ETSejWoqm0-7b2Na976qUm-kc8q0qjHhK_4TXFSnWF2rnRKWKykLLePBsORRxJt4XUfB7fuLoNh8oIOLrfU022efhcSTErjGjtqrU2un-vp6D6fXeQ6Pwpu9nLNxZ6P15yjaebJO0Tjzikpo-VXgo4F1c2MexIDFv2JLow-eS1zYyJm1s0uYCH0T-LLdY_BAUNoFYAZ_EhGbXhpbMTAShl1hDXUUuwL0OXOJKDEv4r2lrZcV5jidKPrh9cWNiC23rDZX2YO50WnZD74gJZbup-EtIwjgVrp7NqzWyEAG_o0fMhBr2OaNhIdILTYftOhBZLggdASWjmV5-3K7EUR27XicPYhF7p2HoGyvE; ai_user=JuOeCmb8X4FUzyzaWj2V+i|2024-05-18T15:29:17.174Z; .AspNetCore.Session=CfDJ8NX9k%2BZQHbNFpdtcPGJPqqV3nicwES%2BEhx0pTmZcNi7RiRMHUNrpWeF9lLgSsATutFY0SOMgu4fhuy1Sn7tk0KtLJiwEM3Ab1uaoTxiE9Ha0qeKGpVSfExJmjMTlD%2BRxeQqwZFS4dCCkNgPS6iY1aerBeQdoWfwd88pn9%2FxfH1iE; ai_session=432riOzOn+xcI67bN8Qzpl|1719077601976|1719079650048");
            request.Headers.Add("Origin", "https://mydata.aade.gr");
            request.Headers.Add("Referer", "https://mydata.aade.gr/timologio/Product/Products");
            request.Headers.Add("Request-Id", "|5ea3f31ebc5546e5b92e296c57000636.f5d3c98d89c0498b");
            request.Headers.Add("Sec-Fetch-Dest", "empty");
            request.Headers.Add("Sec-Fetch-Mode", "cors");
            request.Headers.Add("Sec-Fetch-Site", "same-origin");
            request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36");
            request.Headers.Add("X-Requested-With", "XMLHttpRequest");
            request.Headers.Add("sec-ch-ua", "\"Google Chrome\";v=\"125\", \"Chromium\";v=\"125\", \"Not.A/Brand\";v=\"24\"");
            request.Headers.Add("sec-ch-ua-mobile", "?0");
            request.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
            request.Headers.Add("traceparent", "00-5ea3f31ebc5546e5b92e296c57000636-f5d3c98d89c0498b-01");

            var kefalaioToMyDataVat =  new Dictionary<string, string>()
            {
                { "0","7" },
                { "6","3" },
                { "6.5","" },
                { "13","2" },
                { "19","" },
                { "24","1" },
            };
            var kefalaioToMyDataUnits = new Dictionary<string, string>()
            {
                { "KIΛ","2" },
                { "TMX", "1" }
            };
            
            var myDataUnit =  unit !=null &&  kefalaioToMyDataUnits.ContainsKey(unit)?  kefalaioToMyDataUnits[unit]: string.Empty;
            var myDataVat = vat !=null && kefalaioToMyDataVat.ContainsKey(vat)? kefalaioToMyDataVat[vat] : string.Empty;

            var content = $"prd[afm]=&prd[productType]=1&prd[productCategory]=0&" +
                $"prd[productCode]={code}&" +
                $"prd[taricCode]=&" +
                $"prd[productDescription]={name}&prd" +
                 "[unitPrice]=0&" +
                 $"prd[vatCategory]={myDataVat}&" +
                 $"prd[unit]={myDataUnit}&" +
                 "prd[OtherMeasurementUnitTitle]=&prd[OtherMeasurementUnitQuantity]=&prd[specialType]" +
                 "=&prd[feesWithVAT]=&prd[otherTaxesWithVAT]=&" +
                 "prd[productClassifications][0][_invoiceType]=1&" +
                 "prd[productClassifications][0][selfPricing]=false&" +
                 "prd[productClassifications][0][classificationCategoryCode]=category1_1&" +
                 "prd[productClassifications][0][classificationTypeCode]=E3_561_001";

            request.Content = new StringContent(encodeString(content));
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/x-www-form-urlencoded; charset=UTF-8");

            HttpResponseMessage response = await client.SendAsync(request);            
            string responseBody = await response.Content.ReadAsStringAsync();
            

            if (!response.IsSuccessStatusCode)
            {
                return new ResponseStatus()
                {
                    IsSuccess = false,
                    Message = response.StatusCode.ToString()
                };
            }
            var res = JsonSerializer.Deserialize<MyDataResponse>(responseBody);
            if (res.message !=null)
            {
                
                return new ResponseStatus()
                {
                    IsSuccess = false,
                    Message = res.message
                };
            }

            return new ResponseStatus()
            {
                IsSuccess= true
            };
        }


        private string encodeString(string input)
        {

            string encodedString = Uri.EscapeDataString(input);
            encodedString = encodedString.Replace("%3D", "=").Replace("%26", "&") ;
            return encodedString;
        }

    }

}

/**
 * TODO:
 * hide perivalontiko telos
 * remove unused nuget packages like Serilog.Sinks.RollingFile
 */