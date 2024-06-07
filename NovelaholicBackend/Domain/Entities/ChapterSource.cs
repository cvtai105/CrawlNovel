using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
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