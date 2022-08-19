namespace NLayer.Core.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetProductsWitCategory();

        //Store için eklendi
        Task<List<Product>> GetProductsWitStore();



    }
}
