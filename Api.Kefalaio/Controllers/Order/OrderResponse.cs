namespace Api.Kefalaio.Controllers.Order
{
    public class OrderResponse
    {
        public string Product { get; set; }
        public double? Quantity { get; set; }
        public double? AvgSalesPerDay { get; set; }
        public double? SuggestedQuantity { get; set; }
    }
}
