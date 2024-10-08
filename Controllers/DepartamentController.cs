using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test_Api.Data;
using Test_Api.Models;

namespace Test_Api.Controllers
{
    [ApiController]
    [Route("Departament")]
    public class DepartamentController : ControllerBase
    {
        //Context DB
        private readonly TestApiDbContext _context;
        public DepartamentController(TestApiDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] Department department)
        {
            if (department == null)
            {
                return BadRequest();
            }
            try
            {
                _context.InsertDepartment(department.NameDepartment);
                return Ok("Departament inserted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
    }
}
