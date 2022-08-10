using Develope_REST_API.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Develope_REST_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {

        [HttpGet("get")]
        public IActionResult Get()
        {
            var employee = SomeCompany.GetAllEmployee();
            if(employee == null) 
            {
                return BadRequest("Not found");
            }
            return Ok(employee);
        }
        [HttpGet("get/{id}")]
        public IActionResult Get(int id) 
        {
            var employee = SomeCompany.GetEmployee(id);
            if (employee == null) 
            {
                return BadRequest("Not found");
            }
            return Ok(employee);
        }

        [HttpPost("register")]
        public IActionResult Create()
        {
            return Ok(SomeCompany.CreateEmployee());
        }

        [HttpPut("update/{id},{newId}")]
        public IActionResult Update(int id, int newId) 
        {
            var employee = SomeCompany.UpdateEmployee(id,newId);
            if(employee == null)
            {
                return BadRequest("id not found");
            }
            return Ok(employee);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            SomeCompany.DeleteEmployee(id);
            return Ok("Employee was deleted");
        }
    }
}
