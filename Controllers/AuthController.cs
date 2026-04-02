using LanguageSchoolApp.Data;
using LanguageSchoolApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageSchoolApp.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login(User login)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Username == login.Username
                                  && u.Password == login.Password);

            if (user == null)
                return Unauthorized();

            return Ok(user);
        }
    }
}
