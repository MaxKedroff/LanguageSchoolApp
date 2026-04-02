using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageSchoolApp.Models
{
    public class BoardElement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BoardId { get; set; }

        [Required]
        public string Type { get; set; } = string.Empty; // "rect", "text", "path", "image"

        public string? Data { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }

        public string? Text { get; set; } 
        public string? Points { get; set; } 
        public string? ImageUrl { get; set; } 

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }
    }
}