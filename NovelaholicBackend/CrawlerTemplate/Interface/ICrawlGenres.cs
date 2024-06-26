using Domain.Entities;

namespace ICrawler
{
    public interface ICrawlGenres
    {
        Task<IEnumerable<Genre>> GetGenres();
    }
}