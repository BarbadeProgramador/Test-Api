using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test_Api.Data;
using Test_Api.Models;

namespace Test_Api.Controllers
{
    [ApiController]
    [Route("Country")]
    public class CountryController : ControllerBase
    {
        private readonly TestApiDbContext _context;
        public CountryController(TestApiDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Country countries)
        {
            if (countries == null)
            {
                return BadRequest();
            }
            try
            {
                _context.insertCountry(countries.NameCountry);
                return Ok("Country inserted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
    }
    /*
    [HttpGet]
    [Route("List")]
    public dynamic Listar()
    {

    }*/


}

