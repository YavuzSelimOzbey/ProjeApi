using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjeApi.Business.Abstract;
using ProjeApi.Entities.Concrete;

namespace ProjeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportsController(IReportService reportService)
        {
            _reportService = reportService;
        }

       
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _reportService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("hata");
        }

        [HttpPost("add")]
        public IActionResult Add(Report report)
        {
            var result = _reportService.Add(report);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("işlem tamamlandı");
        }

        [HttpPut("update")]
        public IActionResult Update(Report report)
        {
            var result = _reportService.Update(report);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("İşlem tamamlanmadı.");
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Report report)
        {
            var result = _reportService.Delete(report);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("işlem tamamlandı");
        }
    }

}
