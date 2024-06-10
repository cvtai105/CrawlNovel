using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Common.Entities
{
    [PrimaryKey("ChapterId", "SourceId")]
    public class ChapterSource
    {
        [ForeignKey("Chapter")]
        public int ChapterId { get; set; }
        [ForeignKey("Source")]

        public int SourceId { get; set; }
        [Required]
        public string ChapterUrl { get; set; } = string.Empty;
        public Chapter Chapter { get; set; } = new Chapter();
        public Source Source { get; set; } = new Source();
    }
}