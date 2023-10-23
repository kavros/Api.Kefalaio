namespace Services
{
    public interface IOrdersService
    {
        public Task<IList<Item>> GetOrder(OrderParams orderParams);
        public Task<IList<Supplier>> GetSuppliers();


    }
}
