using Microsoft.AspNetCore.Mvc;
using Test_Api.Data;
using Test_Api.Models;

namespace Test_Api.Controllers
{
    [ApiController]
    [Route("Person")]
    public class PersonController : ControllerBase
    {
        //Context DB
        private readonly TestApiDbContext _context;

        public PersonController(TestApiDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] Person persons)
        {
            if (persons == null)
            {
                return BadRequest();
            }
            try
            {
                _context.insertPerson(persons.Name,persons.Phone,persons.IdCountry,
                                           persons.IdDepartment,persons.IdMunicipality,persons.Address);
                return Ok("Person inserted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }



    }
}
