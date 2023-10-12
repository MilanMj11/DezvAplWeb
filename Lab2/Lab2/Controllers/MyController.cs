using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Lab2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteById(int id)
        {
            return Ok();
        }

        [HttpGet("getAllOrdered")]
        public IActionResult GetAllOrdered()
        {
            return Ok();
        }
    }
}
