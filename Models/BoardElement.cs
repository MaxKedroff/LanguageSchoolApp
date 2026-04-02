namespace LanguageSchoolApp.Models
{
    public class BoardElement
    {
        public int Id { get; set; }
        public int BoardId { get; set; }
        public string Type { get; set; } // draw / image
        public string Data { get; set; } // JSON
    }
}
