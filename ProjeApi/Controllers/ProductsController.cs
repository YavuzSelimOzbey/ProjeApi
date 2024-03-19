using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjeApi.Business.Abstract;
using ProjeApi.Entities.Concrete;

namespace ProjeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _productService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("Hata!");
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("İşlem tamamlanmadı.");
        }

        [HttpPut("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("İşlem tamamlanmadı.");
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("İşlem tamamlanmadı.");
        }
    }
}
