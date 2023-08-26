namespace Api.Kefalaio.Controllers.Order
{
    public class Item
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public int AvgSalesPerDay { get; set; }
        public int SuggestedQuantity { get; set; }
    }
}
