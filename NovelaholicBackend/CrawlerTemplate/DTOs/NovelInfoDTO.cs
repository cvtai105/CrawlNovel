using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlerTemplate.DTOs
{
    public class NovelInfoDTO 
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CoverUrl { get; set; } = string.Empty;
        public string NovelUrl { get; set; } = string.Empty;
        public IEnumerable<string> Genres { get; set; } = new List<string>();
        public IEnumerable<ChapterDTO> Chapters { get; set; } = new List<ChapterDTO>();   
    }
}