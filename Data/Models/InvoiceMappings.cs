namespace Data.Models
{
    public class InvoiceMappings
    {
        public int Id { get; set; } 
        public required string DocumentId { get; set; }
        public required string QRUrl { get; set; }
        public long? InvoiceMark { get; set; }
    }

}
