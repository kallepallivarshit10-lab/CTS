using Microsoft.AspNetCore.Mvc;
using FirstWebAPI.Models;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("Emp")]
    public class EmployeeController : ControllerBase
    {
        // Hardcoded Employee List
        private static List<Employee> employees = new List<Employee>
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
                Name = "varshit varma",
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

        // GET
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        // POST
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }

        // PUT
        [HttpPut]
        public ActionResult<Employee> Put([FromBody] Employee employee)
        {
            // Check for invalid ID
            if (employee.Id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            // Find employee
            var existingEmployee = employees.FirstOrDefault(e => e.Id == employee.Id);

            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            // Update employee
            existingEmployee.Name = employee.Name;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.Permanent = employee.Permanent;
            existingEmployee.Department = employee.Department;
            existingEmployee.Skills = employee.Skills;
            existingEmployee.DateOfBirth = employee.DateOfBirth;

            // Return updated employee
            return Ok(existingEmployee);
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return BadRequest("Invalid employee id");
            }

            employees.Remove(employee);

            return Ok("Employee deleted successfully.");
        }
    }
}
