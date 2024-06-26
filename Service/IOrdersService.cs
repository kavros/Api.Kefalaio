using Data;

namespace Services
{
    public interface IOrdersService
    {
        public Task<IList<Item>> GetOrder(OrderParams orderParams);
        public Task<IList<Supplier>> GetSuppliers();
        Task<IList<Product>> GetAllProducts();
        Task AddToFailures(List<MyDataFailedImports> rows);


    }
}
