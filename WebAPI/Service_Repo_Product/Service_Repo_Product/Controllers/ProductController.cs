using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service_Repo_Product.Interfaces;
using Service_Repo_Product.Models;

namespace Service_Repo_Product.Controllers
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
        public ActionResult<IEnumerable<Product>> GetAll() 
        {
            var pdts = _service.GetAll();
            return Ok(pdts);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var pdt = _service.GetById(id);
            if (pdt == null) return NotFound();
            return Ok(pdt);
        }

        [HttpPost]
        public ActionResult Create(Product pdt)
        {
            _service.Add(pdt);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id,Product pdt)
        {
            if (id != pdt.Id) return BadRequest("Id mismatch");
            var p = _service.GetById(id);
            p.PdtName = pdt.PdtName;
            p.Desc=pdt.Desc;
            p.Price = pdt.Price;
            _service.Update(p);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id) 
        {
            var p = _service.GetById(id);
            if (p == null) return NotFound();
            _service.Delete(id);
            return Ok();
        }
    }
}
