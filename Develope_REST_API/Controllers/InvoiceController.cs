using Develope_REST_API.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Develope_REST_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : Controller
    {
        [HttpGet("get")]
        public IActionResult Get() 
        {
            var listInvoices = SomeCompany.GetAllInvoices();
            if(listInvoices != null)
            {
                return Ok(listInvoices);
            }
            return BadRequest("Invoices not found.");
        }
        [HttpGet("get/{id}")]
        public IActionResult Get(int id)
        {
            var invoice = SomeCompany.GetInvoice(id);
            if(invoice != null)
            {
                return Ok(invoice);
            }
            return BadRequest("Not found");
        }
        [HttpPost("register")]
        public IActionResult CreateInvoice()
        {
            var invoice = SomeCompany.CreateInvoice();
            return Ok(invoice);
        }

        [HttpPut("update/{id},{newId}")]
        public IActionResult Update(int id, int newId)
        {
            var updatedInvoice = SomeCompany.UpdateInvoice(id, newId);
            if(updatedInvoice != null)
            {
                return Ok(updatedInvoice);
            }
            return BadRequest("Invoice not updated");
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var isDeleted = SomeCompany.DeleteInvoice(id);
            if (isDeleted)
            {
                return Ok("Deleted");
            }
            return BadRequest("Invoice not deleted, incorrect ID");
        }
    }
}
