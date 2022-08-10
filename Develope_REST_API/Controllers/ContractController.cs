using Develope_REST_API.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Develope_REST_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractController : Controller
    {
        [HttpGet("get")]
        public IActionResult Get()
        {
            var listContract = SomeCompany.GetAllContract();
            if(listContract == null)
            {
                return BadRequest("Contracts not found.");
            }
            return Ok(listContract);
        }
        [HttpGet("get/{id}")]
        public IActionResult Get(int id) 
        {
            var contract = SomeCompany.GetContract(id);
            if(contract == null)
            {
                return BadRequest("Contract not found");
            }
            return Ok(contract);
        }

        [HttpPost("register")]
        public IActionResult Create()
        {
            var contract = SomeCompany.CreateContract();
            return Ok(contract);
        }

        [HttpPut("update/{id},{newId}")]
        public IActionResult Update(int id, int newId) 
        {
            var contract = SomeCompany.UpdateContract(id, newId);
            if(contract != null)
            {
                return Ok(contract);
            }
            return BadRequest("Contract not updated");
        }

        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var isDeleted = SomeCompany.DeleteContract(id);
            if (isDeleted)
            {
                return Ok("Deleted");
            }
            return BadRequest("Contract not deleted, incorrect ID");
        }
    }
}
