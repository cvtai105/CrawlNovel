using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ChapterSource
    {
        [Key]
        public int ChapterId { get; set; }
        [Key]
        public int SourceId { get; set; }
        [Required]
        public string ChapterUrl { get; set; } = string.Empty;
        public Chapter Chapter { get; set; } = new Chapter();
        public Source Source { get; set; } = new Source();
    }
}