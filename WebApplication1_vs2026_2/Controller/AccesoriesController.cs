using Microsoft.AspNetCore.Mvc;
using WebApplication1_vs2026_2.Repository;

namespace WebApplication1_vs2026_2.Controller
{

    [ApiController]
    [Route("api/[controller]")]
    public class AccesoriesController : ControllerBase
    {

        public readonly RepositoryAccesories _repositoryAccesories;
        public AccesoriesController(RepositoryAccesories repositoryAccesories)
        {
            _repositoryAccesories = repositoryAccesories;
        }


        [HttpGet]
        public IActionResult getAccesories()
        {
            var accesories = _repositoryAccesories.GetAllAccesories();
            return Ok(accesories);
        }

        [HttpGet("{model}")]
        public IActionResult getAccesoriesByModel(string model)
        {
            var accesories = _repositoryAccesories.GetAccesoriesByModel(model);
            if (accesories == null)
            {
                return NotFound();
            }
            return Ok(accesories);
        }
    }
}
