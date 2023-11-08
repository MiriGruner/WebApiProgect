using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using servies;

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;
        public CategoryController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> Get()
        {
            IEnumerable<Category> categories = await _categoriesService.getAllCategories();
            return Ok(categories);
        }
        [HttpGet("id")]

        public async Task<ActionResult<Category>> GetById(int id)
        {
           Category category=  await _categoriesService.getCategoryById(id);
            if (category == null)
                return NoContent();

            return Ok(category);
        }
        }

}

