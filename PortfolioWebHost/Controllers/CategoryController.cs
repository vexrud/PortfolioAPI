using Core.Entities;
using Infrastructure.Abstract;
using Infrastructure.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebHost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly EfCategoryDal _categoryRepository;
        public CategoryController(
            EfCategoryDal categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_categoryRepository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Category entity)
        {
            _categoryRepository.Add(entity);
            return Ok(entity.Id);
        }
    }
}
