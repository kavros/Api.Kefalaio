using Services.Models;

namespace Services
{
    public interface IMyDataService
    {
        public Task<SendInvoiceResponse> SendInvoice(Invoice invoice);
        public Task<string?> CancelInvoice(string documentId);
        public Task<IList<string>> GetMyDataInvoices();
        public Task<IList<Invoice>> GetAllInvoices();
    }
}
