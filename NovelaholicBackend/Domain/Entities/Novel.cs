using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public bool IsHot { get; set; }
        public List<Genre> Genres { get; set; } = [];
        public List<Chapter> Chapters { get; set; } = [];
        public void AscendingSortChapters(){
            Chapters.Sort((c1, c2) => c1.Number - c2.Number);
        }
        public void DescendingSortChapters(){
            Chapters.Sort((c1, c2) => c2.Number - c1.Number);
        }
        public bool IsEquals(Novel n2){
            return VietnameseTitle == n2.VietnameseTitle;
        }
        public virtual List<NovelSource> NovelSources { get; set; } = [];
    }
}