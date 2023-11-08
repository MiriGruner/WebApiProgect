using Entities;
using Microsoft.AspNetCore.Mvc;
using servies;
using System.Collections.Generic;

namespace project.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
           IEnumerable <Product> products =  await _productService.getAllProducts();    
            return  Ok(products);
        }

        }
}
