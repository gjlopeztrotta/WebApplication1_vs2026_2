using Microsoft.AspNetCore.Mvc;
using WebApplication1_vs2026_3Async.Repository;

namespace WebApplication1_vs2026_3Async.Controller
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
        public async Task<IActionResult> GetOfferById(int id)
        {
            var offer = await _repoOfertas.GetOfferByIdAsync(id);
            if (offer == null)
            {
                return NotFound();
            }
            return Ok(offer);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOffers()
        {
            var offers = await _repoOfertas.GetAllOffersAsync();
            return Ok(offers);
        }

    }
}
