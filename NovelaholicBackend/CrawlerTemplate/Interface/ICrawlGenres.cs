
using CrawlerTemplate.DTOs;

namespace ICrawler
{
    public interface ICrawlGenres
    {
        Task<IEnumerable<string>> GetGenres();
    }
}