
using CrawlerTemplate.DTOs;

namespace ICrawler
{
    public interface ICrawlNovels
    {
        Task<IEnumerable<NovelInfoDTO>> GetNovels(string genre);
    }
}