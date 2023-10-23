namespace Services
{
    public class OrderParams
    {
        public int NextOrderAfter { get; set; }
        public string SupplierCode { get; set; }
        public int DateWindow { get; set; }
    }
}
