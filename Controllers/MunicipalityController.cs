using Microsoft.AspNetCore.Mvc;
using Test_Api.Data;
using Test_Api.Models;

namespace Test_Api.Controllers
{
    [ApiController]
    [Route("Municipality")]
    public class MunicipalityController : ControllerBase
    {
        //Context DB
        private readonly TestApiDbContext _context;

        public MunicipalityController(TestApiDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] Municipality municipalities)
        {
            if (municipalities == null)
            {
                return BadRequest();
            }
            try
            {
                _context.insertMunicipality(municipalities.NameMunicipality);
                return Ok("Municipality inserted successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
    }
}
