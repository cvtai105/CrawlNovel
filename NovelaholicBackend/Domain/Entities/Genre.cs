using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public List<Novel> Novels { get; set; } = new List<Novel>();
    }
}