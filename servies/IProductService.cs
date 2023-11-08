using Entities;

namespace servies
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> getAllProducts();
    }
}