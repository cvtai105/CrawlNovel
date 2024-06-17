
using CrawlerTemplate.DTOs;

namespace ICrawler
{
    public interface ICrawlUpdateds
    {
        Task<IEnumerable<NovelUpdateDTO>> GetUpdateds();
    }
}