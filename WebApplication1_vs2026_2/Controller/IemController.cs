using Microsoft.AspNetCore.Mvc;
using WebApplication1_vs2026_2.Repository;

namespace WebApplication1_vs2026_2.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class IemController : ControllerBase
    {

        public readonly RepositoryIEM _repositoryIem;

        public IemController(RepositoryIEM repositoryIem)
        {
            _repositoryIem = repositoryIem;
        }

        [HttpGet]
        public IActionResult getIEM()
        {

            var iem = _repositoryIem.GetAllIEM();
            return Ok(iem);
        }
        [HttpGet("{horsepower}")]
        public IActionResult getIEMById(int horsepower)
        {
            var iem = _repositoryIem.GetIEMByHorsepower(horsepower);
            if (iem == null)
            {
                return NotFound();
            }
            return Ok(iem);
        }
    }
}
