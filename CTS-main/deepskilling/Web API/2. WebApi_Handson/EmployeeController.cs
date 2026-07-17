using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("Emp")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var employees = new List<string>
            {
                "John",
                "David",
                "Alice",
                "Varshit varma"
            };

            return Ok(employees);
        }
    }
}
