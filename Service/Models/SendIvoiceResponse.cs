using MyData.Xsd;

namespace Services.Models
{
    public class SendInvoiceResponse
    {
        public required AadeBookInvoiceType InvoiceData { get; set; }
        public required string QRUrl { get; set; }
        public required string InvoiceUID { get; set; }
        public long? InvoiceMark { get; set; }
    }
}
