using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI4.DAL;

namespace WebAPI4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebUserController : ControllerBase
    {
        MyCompanyDbContext _context;
        public WebUserController()
        {
            _context = new MyCompanyDbContext();
        }
        
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var webUsers = _context.WebUsers.ToList();
            return Ok(webUsers);
        }

    }
}
