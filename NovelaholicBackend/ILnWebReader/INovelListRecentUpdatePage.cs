using Domain.Entities;

namespace ILnWebReader
{
    public interface INovelListRecentUpdatePage
    {
        Task<IEnumerable<Novel>> GetRecentUpdateNovels();
        Task<IEnumerable<Genre>> GetGenres(int page);
    }
}