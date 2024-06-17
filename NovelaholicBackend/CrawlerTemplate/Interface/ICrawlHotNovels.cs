
using CrawlerTemplate.DTOs;

namespace ICrawler
{
    public interface ICrawlHotNovels
    {
        Task<IEnumerable<NovelInfoDTO>> GetHotNovels();
    }
}