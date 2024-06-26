using Domain.Entities;

namespace ICrawler
{
    public interface ICrawlHotNovels
    {
        Task<IEnumerable<Novel>> GetHotNovels();
    }
}