using Microsoft.AspNetCore.Mvc;
using WebApplication1_vs2026_2.Models;
using WebApplication1_vs2026_2.Repository;

namespace WebApplication1_vs2026_2.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class OffersController : ControllerBase
    {
        private readonly RepositoryOffer _repoOfertas;

        public OffersController(RepositoryOffer repoOfertas)
        {
            _repoOfertas = repoOfertas;
            
        }

        [HttpGet("{id}")]
        public IActionResult GetOfferById(int id)
        {
            var offer = _repoOfertas.GetOfferById(id);
            if (offer == null)
            {
                return NotFound();
            }
            return Ok(offer);
        }

        [HttpGet]
        public IActionResult GetAllOffers()
        {
            var offers = _repoOfertas.GetAllOffers();
            return Ok(offers);
        }


    }
}
