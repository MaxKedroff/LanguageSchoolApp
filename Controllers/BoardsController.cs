using LanguageSchoolApp.Data;
using LanguageSchoolApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageSchoolApp.Controllers
{
    [ApiController]
    [Route("api/boards")]
    public class BoardsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BoardsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{userId}")]
        public IActionResult GetBoards(int userId)
        {
            var boards = _context.UserBoards
                .Where(ub => ub.UserId == userId)
                .Select(ub => ub.Board)
                .ToList();

            return Ok(boards);
        }

        [HttpPost("assign")]
        public IActionResult AssignUserToBoard(int userId, int boardId)
        {
            var ub = new UserBoard
            {
                UserId = userId,
                BoardId = boardId
            };

            _context.UserBoards.Add(ub);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPost]
        public IActionResult CreateBoard(Board board)
        {
            _context.Boards.Add(board);
            _context.SaveChanges();
            return Ok(board);
        }
    }
}
