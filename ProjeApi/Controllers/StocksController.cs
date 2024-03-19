using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjeApi.Business.Abstract;
using ProjeApi.Entities.Concrete;

namespace ProjeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IStockService _stockService;

        public StocksController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _stockService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("Hata oluştu");
        }

        [HttpPost("add")]
        public IActionResult Add(Stock stock)
        {
            var result = _stockService.Add(stock);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("İşlem tamamlandı");
        }

        
        [HttpPut("update")]
        public IActionResult Update(Stock stock)
        {
            var result = _stockService.Update(stock);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("İşlem tamamlanmadı.");
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Stock stock)
        {
            var result = _stockService.Delete(stock);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("İşlem tamamlandı");
        }
    }

}
