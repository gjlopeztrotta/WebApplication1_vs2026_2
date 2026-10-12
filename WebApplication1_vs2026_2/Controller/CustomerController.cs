using Microsoft.AspNetCore.Mvc;
using WebApplication1_vs2026_2.Repository;

namespace WebApplication1_vs2026_2.Controller
{

    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        
        public readonly RepositoryCustomer _repositoryCustomer;

        public CustomerController(RepositoryCustomer repositoryCustomer)
        {
            _repositoryCustomer = repositoryCustomer;
        }   
        
        [HttpGet]
        public IActionResult getallCustomer()
        {

            var customers = _repositoryCustomer.GetAllCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public IActionResult getCustomerById(string id)
        {
            var customer = _repositoryCustomer.GetCustomerByNif(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }
    }
}
