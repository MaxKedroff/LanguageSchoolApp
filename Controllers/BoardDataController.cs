using LanguageSchoolApp.Data;
using LanguageSchoolApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var elements = _context.BoardElements
                .Where(e => e.BoardId == boardId)
                .OrderBy(e => e.Id)
                .ToList();

            return Ok(elements);
        }

        [HttpPost]
        public IActionResult Save([FromBody] SaveBoardDataRequest request)
        {
            var oldElements = _context.BoardElements
                .Where(e => e.BoardId == request.BoardId);

            _context.BoardElements.RemoveRange(oldElements);

            foreach (var element in request.Elements)
            {
                element.BoardId = request.BoardId;
                element.Id = 0; 
                _context.BoardElements.Add(element);
            }

            _context.SaveChanges();
            return Ok(new { message = "Saved successfully", count = request.Elements.Count });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] BoardElement element)
        {
            var existingElement = _context.BoardElements.Find(id);
            if (existingElement == null)
                return NotFound();

            existingElement.Type = element.Type;
            existingElement.Data = element.Data;
            existingElement.X = element.X;
            existingElement.Y = element.Y;
            existingElement.Width = element.Width;
            existingElement.Height = element.Height;

            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var element = _context.BoardElements.Find(id);
            if (element == null)
                return NotFound();

            _context.BoardElements.Remove(element);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("board/{boardId}")]
        public IActionResult ClearBoard(int boardId)
        {
            var elements = _context.BoardElements
                .Where(e => e.BoardId == boardId);

            _context.BoardElements.RemoveRange(elements);
            _context.SaveChanges();

            return Ok();
        }
    }

    public class SaveBoardDataRequest
    {
        public int BoardId { get; set; }
        public List<BoardElement> Elements { get; set; } = new List<BoardElement>();
    }
}