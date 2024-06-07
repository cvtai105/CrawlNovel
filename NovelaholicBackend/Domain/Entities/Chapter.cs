using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Chapter
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Title { get; set; } = string.Empty;
        [Required]
        public int Number { get; set; }
        [Required]
        public int NovelId { get; set; }
        public virtual Novel Novel { get; set; } = new Novel();
        public virtual ICollection<ChapterSource> ChapterSources { get; set; } = new List<ChapterSource>();
    }
}