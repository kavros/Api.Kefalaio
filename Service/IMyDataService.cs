using Services.Models;

namespace Services
{
    public interface IMyDataService
    {
        public Task<SendInvoiceResponse> SendInvoice(Invoice invoice);
        public Task<IList<Invoice>> GetAllInvoices();
    }
}
