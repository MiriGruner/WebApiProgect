using Entities;

namespace repository
{
    public interface IProductsRepository
    {
        Task<IEnumerable<Product>> getAllProducts();
    }
}