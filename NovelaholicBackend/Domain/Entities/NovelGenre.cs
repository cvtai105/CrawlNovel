using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class NovelGenre
    {
        public int NovelId { get; set; }
        public int GenreId { get; set; }
        [Required]
        public Novel Novel { get; set; } = new();
        [Required]
        public Genre Genre { get; set; } = new Genre();
    }
}