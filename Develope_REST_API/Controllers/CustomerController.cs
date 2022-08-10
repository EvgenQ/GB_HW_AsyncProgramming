using Develope_REST_API.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Develope_REST_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        [HttpGet("get")]
        public IActionResult Get()
        {
            var customer = SomeCompany.GetAllCustomers();
            return Ok(customer);
        }
        [HttpGet("get/{id}")]
        public IActionResult Get(int id)
        {
            var customer = SomeCompany.GetCustomers(id);
            if(customer != null)
            {
                return Ok(customer);
            }
            return BadRequest("Customer not found.");
        }

        [HttpPost("register")]
        public IActionResult Create()
        {
            var customer = SomeCompany.CreateCustomer();

            return Ok(customer);
        }

        [HttpPut("update/{id},{newId}")]
        public IActionResult Update(int id, int newId)
        {
            var customer = SomeCompany.UpdateCustomer(id, newId);
            if(customer != null)
            {
                return Ok(customer);
            }
            return BadRequest("Customer ID not updated");
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            for (int i = 0; i < SomeCompany.customers.Count; i++)
            {
                if(SomeCompany.customers[i].Id == id) 
                {
                    SomeCompany.customers.Remove(SomeCompany.customers[i]);
                    return Ok("Пользователь удален.");
                }
            }

            return BadRequest($"Пользователь с ID {id} не найден.");
        }

    }
}
