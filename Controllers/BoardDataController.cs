using LanguageSchoolApp.Data;
using LanguageSchoolApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageSchoolApp.Controllers
{
    [ApiController]
    [Route("api/boarddata")]
    public class BoardDataController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BoardDataController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{boardId}")]
        public IActionResult Get(int boardId)
        {
            return Ok(_context.BoardElements
                .Where(e => e.BoardId == boardId));
        }

        [HttpPost]
        public IActionResult Save(BoardElement element)
        {
            _context.BoardElements.Add(element);
            _context.SaveChanges();
            return Ok();
        }
    }
}
