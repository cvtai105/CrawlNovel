using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class NovelSource
    {
        public int NovelId { get; set; }
        public int SourceId { get; set; }
        [Required]
        public string NovelUrl { get; set; } = String.Empty;
        [Required]
        public Novel Novel { get; set; } = new();
        public Source Source { get; set; } = new Source();
    }
}