using Microsoft.AspNetCore.Mvc;
using WebApplication1_vs2026_2.Repository;
using WebApplication1_vs2026_2.Models; // <- añadir si Tax está en este namespace

namespace WebApplication1_vs2026_2.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaxController : ControllerBase
    {
        private readonly RepositoryTax _repositoryTax;

        public TaxController(RepositoryTax repositoryTax)
        {
            _repositoryTax = repositoryTax;
        }

        [HttpGet]
        public IActionResult GetTax()
        {
            var tax = _repositoryTax.GetAllTaxes();
            return Ok(tax);
        }

        [HttpGet("{country}")]
        public IActionResult GetTaxById(string country)
        {
            var tax = _repositoryTax.GetAllTaxes();
            if (tax == null)
            {
                return NotFound();
            }
            return Ok(tax.FirstOrDefault(x => x.Taxcountry == country));
        }
    }
}
