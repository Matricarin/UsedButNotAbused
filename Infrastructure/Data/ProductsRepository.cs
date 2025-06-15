using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductsRepository : IProductsRepository
    {
        private StoreContext _context;

        public ProductsRepository(StoreContext context)
        {
            _context = context;
        }
        
        public async Task<Product?> GetProductByIdAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                throw new NullReferenceException($"{nameof(product)} : {typeof(Product)}");
            }

            return product;
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}