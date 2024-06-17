using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawlerTemplate.DTOs
{
    public class ChapterDTO
    {
        public string Title { get; set; } = string.Empty;
        public int Number { get; set; }
        public string ContentUrl { get; set; } = string.Empty;

    }
}