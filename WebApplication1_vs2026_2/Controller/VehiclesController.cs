using Microsoft.AspNetCore.Mvc;
using WebApplication1_vs2026_2.Repository;

namespace WebApplication1_vs2026_2.Controller
{

    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly RepositoryVehicle _repovehicles;

        public VehiclesController(RepositoryVehicle repovehicles)
        {
            _repovehicles = repovehicles;
        }


        [HttpGet()]
        public IActionResult GetAllVehicles()
        {
            var vehicles = _repovehicles.ListVehicles;
            return Ok(vehicles);
        }

    }
    
}
