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
    }
    //TODO:
    //!!!handle product discount!
    //seira?
    //aa?
    //cancel invoice?
    //! use correct appSettings.json based on the environment

}
