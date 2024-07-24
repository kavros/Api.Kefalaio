using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Models;
using System.Threading.Tasks;

namespace Api.Kefalaio.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MyDataController: ControllerBase
    {
        private readonly IMyDataService _myDataService;

        public MyDataController(IMyDataService myDataService)
        {
            _myDataService = myDataService;

        }
        [HttpGet]
        [Route("GetAllInvoices")]
        public async Task<IActionResult> GetAllInvoices()
        {
            var res = await _myDataService.GetAllInvoices();
            return Ok(res);
        }

        [HttpPost]
        [Route("SendInvoice")]
        public async Task<IActionResult> SendInvoice(Invoice invoice)
        {
            var res = await _myDataService.SendInvoice(invoice);
            return Ok(res);
        }

        [HttpGet]
        [Route("GetMyDataInvoices")]
        public async Task<IActionResult> GetMyDataInvoices()
        {
            return Ok(await _myDataService.GetMyDataInvoices());
        }

        public class CancelInvoiceDTO
        {
            public string DocumentId { get; set; }
        }

        [HttpPost]
        [Route("CancelInvoice")]
        public async Task<IActionResult> CancelInvoice(CancelInvoiceDTO data)
        {
            var res = await _myDataService.CancelInvoice(data.DocumentId);
            return Ok(res);
        }
    }    
}
