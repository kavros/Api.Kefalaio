using MyData.Xsd;

namespace Services.Models
{
    public class InvoiceRow
    {
        public required string Code { get; set; }
        
        public required string Description { get; set; }
        public double? Quantity { get; set; }
        public string? MM { get; set; }
        public double? Price {  get; set; }
        public double? Discount { get; set; }
        public double? NetValue { get; set; }
        public double? Vat { get; set; } //%
        public double? VatAmount { get; set; }//euro
        public double? Amount { get; set; }
    }
    public  class CustomerDetails
    {
        public required string VatNumber { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
    }
    public class MyDataDetails
    {
        public required string QRUrl { get; set; }
        public long? InvoiceMark { get; set; }
        public required string PaymentMethod { get; set; }
        public required DateTime CreatedDate { get; set; }
    }
    public class SendInvoiceResponse
    {
        public required CustomerDetails CustomerDetails { get; set; }
        public required List<InvoiceRow> InvoiceRows { get; set; }
        public required MyDataDetails MyDataDetails { get; set; }
    }
}
