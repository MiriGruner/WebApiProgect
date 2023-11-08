using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly Store21Context _DbContext;

        public ProductsRepository(Store21Context dbContext)
        {
            _DbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> getAllProducts()
        {
            return await _DbContext.Products.ToListAsync();
        }

    }
}
