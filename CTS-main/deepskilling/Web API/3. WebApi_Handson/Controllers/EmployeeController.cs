using Microsoft.AspNetCore.Mvc;
using FirstWebAPI.Models;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("Emp")]
    // [CustomAuthFilter]   // Temporarily removed for Part 3
    public class EmployeeController : ControllerBase
    {
        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department
                    {
                        Id = 1,
                        Name = "IT"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "SQL" }
                    },
                    DateOfBirth = new DateTime(1998, 5, 20)
                },

                new Employee
                {
                    Id = 2,
                    Name = "Jyothirmai Chapala",
                    Salary = 65000,
                    Permanent = true,
                    Department = new Department
                    {
                        Id = 2,
                        Name = "Data Science"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "Python" },
                        new Skill { Id = 2, Name = "Machine Learning" }
                    },
                    DateOfBirth = new DateTime(2006, 8, 25)
                }
            };
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> GetStandard()
        {
            throw new Exception("This is a custom exception generated for testing.");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            return Ok(employee);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Employee employee)
        {
            return Ok(employee);
        }
    }
}                                   