using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.DomainLayer.Entities;
using OnionArchitecture.ServiceLayer.CustomerService;
using System.Threading.Tasks;

namespace OnionArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet(nameof(GetCustomer))]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var result = await _customerService.GetCustomer(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpGet(nameof(GetAllCustomer))]
        public async Task<IActionResult> GetAllCustomer()
        {
            var result = await _customerService.GetAllCustomers();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No records found");
        }

        [HttpPost(nameof(InsertCustomer))]
        public async Task<IActionResult> InsertCustomer(Customer customer)
        {
            await _customerService.InsertCustomer(customer);
            return Ok("Data inserted");
        }

        [HttpPut(nameof(UpdateCustomer))]
        public async Task<IActionResult> UpdateCustomer(Customer customer)
        {
            await _customerService.UpdateCustomer(customer);
            return Ok("Updation done");
        }

        [HttpDelete(nameof(DeleteCustomer))]
        public async Task<IActionResult> DeleteCustomer(int Id)
        {
            await _customerService.DeleteCustomer(Id);
            return Ok("Data Deleted");
        }
    }
}
