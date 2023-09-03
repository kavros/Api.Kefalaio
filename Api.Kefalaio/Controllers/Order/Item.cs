namespace Api.Kefalaio.Controllers.Order
{
    public class Item
    {
        public string Product { get; set; }
        public int Stock { get; set; }
        public double AvgSalesPerDay { get; set; }
        public int SuggestedQuantity { get; set; }
    }
}
