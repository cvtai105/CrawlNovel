
using Domain.Entities;

namespace ICrawler
{
    public interface ICrawlNovels
    {
        Task<IEnumerable<Novel>> GetNovels();
    }
}