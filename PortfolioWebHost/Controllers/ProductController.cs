using Application.Interfaces;
using Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWebHost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_service.GetAllRecord());
            }
            catch (Exception err)
            {

                return BadRequest($"Bir sorun oluştu. Hata mesajı: {err.Message}");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                return Ok(_service.GetRecordById(id));
            }
            catch (Exception err)
            {

                return BadRequest($"Bir sorun oluştu. Hata mesajı: {err.Message}"); ;
            }
        }

        [HttpPost]
        public IActionResult Insert(Product entity)
        {
            try
            {
                _service.AddRecord(entity);
                return Ok("Veri ekleme işlemi başarılı.");
            }
            catch (Exception err)
            {

                return BadRequest($"Bir sorun oluştu. Hata mesajı: {err.Message}");
            }
        }

        [HttpPut]
        public IActionResult Update(Product entity)
        {
            try
            {
                _service.UpdateRecord(entity);
                return Ok("Veri güncelleme işlemi başarılı.");
            }
            catch (Exception err)
            {

                return BadRequest($"Bir sorun oluştu. Hata mesajı: {err.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _service.DeleteRecord(id);
                return Ok("Veri silme işlemi başarılı.");
            }
            catch (Exception err)
            {

                return BadRequest($"Bir sorun oluştu. Hata mesajı: {err.Message}");
            }
        }
    }
}
