﻿using Entities;
using repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servies
{
    public class ProductService : IProductService
    {

        private readonly IProductsRepository _productService;
        public ProductService(IProductsRepository productService)
        {
            _productService = productService;
        }
        public async Task<IEnumerable<Product>> getAllProducts()
        {
            return await _productService.getAllProducts();
        }
    }
}
