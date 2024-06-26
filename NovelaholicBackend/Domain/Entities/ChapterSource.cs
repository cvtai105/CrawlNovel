using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ChapterSource
    {
        public int ChapterId { get; set; }
        public int SourceId { get; set; }
        [Required]
        public string ChapterUrl { get; set; } = String.Empty;
        [Required]
        public Chapter Chapter { get; set; } = new Chapter();
        public Source Source { get; set; } = new Source();
    }
}