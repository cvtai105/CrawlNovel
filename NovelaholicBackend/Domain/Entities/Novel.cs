using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Novel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string PrimaryTitle { get; set; } = string.Empty;
        [Required]
        [MaxLength(255)]
        public string VietnameseTitle { get; set; } = string.Empty;
        [MaxLength(255)]
        public string Author { get; set; } = string.Empty;
        [MaxLength(511)]
        public string Description { get; set; } = string.Empty;
        [MaxLength(255)]
        public string Cover { get; set; } = string.Empty;
        [MaxLength(32)]
        public string Status { get; set; } = string.Empty;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int ViewCount { get; set; }
        public int LikeCount { get; set; }
        [Column (TypeName = "decimal(3, 1)")]
        public decimal Rating { get; set; } 

        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<Chapter> Chapters { get; set; } = new List<Chapter>();
        public virtual List<Source> Sources { get; set; } = new List<Source>();
    }
}