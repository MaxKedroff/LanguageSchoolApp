namespace LanguageSchoolApp.Models
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<UserBoard>? UserBoards { get; set; }
    }
}
