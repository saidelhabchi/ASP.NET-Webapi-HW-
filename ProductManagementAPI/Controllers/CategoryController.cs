using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO;
using ServiceLayer.Service.CategoryService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<CategoryDto> Get()
        {
            return _categoryService.getCatgories();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public CategoryDto Get(int id)
        {
            return _categoryService.getCategory(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] CategoryDto value)
        {
            _categoryService.addCategory(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CategoryDto value)
        {
            _categoryService.updateCategory(id, value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _categoryService.removeCategory(id);
        }
    }
}
