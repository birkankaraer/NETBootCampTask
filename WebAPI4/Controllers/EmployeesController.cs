using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI4.DAL;

namespace WebAPI4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        MyCompanyDbContext db;
        public EmployeesController()
        {
            db = new MyCompanyDbContext();
        }

        //create employee get, post, put, delete
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var employees = db.Employees.ToList();
            return Ok(employees);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var employee = db.Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return NotFound();
            return Ok(employee);
        }
        [HttpPost("create")]
        public IActionResult Create(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = employee.Id }, employee);
        }
        [HttpPut("update")]
        public IActionResult Update(Employee employee)
        {
            var employeeToUpdate = db.Employees.FirstOrDefault(e => e.Id == employee.Id);
            if (employeeToUpdate == null)
                return NotFound();
            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.LastName = employee.LastName;
            employeeToUpdate.Address = employee.Address;
            employeeToUpdate.BirthDate = employee.BirthDate;
            employeeToUpdate.City = employee.City;
            db.SaveChanges();
            return Ok();
        }
        [HttpDelete("delete")]
        public IActionResult DeleteById(int id)
        {
            var employeeToDelete = db.Employees.FirstOrDefault(e => e.Id == id);
            if (employeeToDelete == null)
                return NotFound();
            db.Employees.Remove(employeeToDelete);
            db.SaveChanges();
            return Ok();
        }

    }
}
