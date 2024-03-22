using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTO;
using ServiceLayer.Service.ProductService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<ProductDto> Get()
        {
            return _productService.getProducts();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public ProductDto Get(int id)
        {
            return _productService.getProduct(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] ProductDto value)
        {
            _productService.addProduct(value);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProductDto value)
        {
            _productService.updateProduct(id, value);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productService.removeProduct(id);
        }
    }
}
