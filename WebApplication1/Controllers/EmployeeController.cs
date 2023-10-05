using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
      
        private readonly EmpDbContext _db;
        public EmployeeController( EmpDbContext db)
        {
           
            _db = db;
        }

        [HttpGet("{dept}", Name = "GetByDepartment")]
         
        public IActionResult GetByDepartment (string dept)
        {
            if(dept == null)
            {
                return BadRequest();
            }
            List<EmployeeModel> employees = new List<EmployeeModel>();
            employees = _db.Employees.Where(e => e.Department == dept).ToList();
            return Ok(employees);
        }

        [HttpGet( Name = "SortOnSalary")]
        public IActionResult SortOnSalary ()
        {

            var list = _db.Employees.OrderByDescending(e => e.salary).ToList();
           
            return Ok(list);
        }

        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetbyId(int  id)
        {
            if(id == 0)
                return BadRequest();

            var Emp = _db.Employees.FirstOrDefault(e => e.EmployeeId == id);
            if (Emp == null)
                return NotFound();
            return Ok(Emp);
        }
    }
}
