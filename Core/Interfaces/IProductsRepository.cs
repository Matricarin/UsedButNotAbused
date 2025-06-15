using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductsRepository
    {
        Task<Product?> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}