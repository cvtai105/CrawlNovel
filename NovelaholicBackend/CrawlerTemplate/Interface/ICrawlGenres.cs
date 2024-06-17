
using CrawlerTemplate.DTOs;

namespace ICrawler
{
    public interface ICrawlGenres
    {
        Task<IEnumerable<GenreDTO>> GetGenres();
    }
}