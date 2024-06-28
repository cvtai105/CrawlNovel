using Domain.Entities;

namespace Domain.IRepository
{
    public interface INovelRepository
    {
        Task<IEnumerable<Novel>> AddNovels(IEnumerable<Novel> newNovels);
        Task<IEnumerable<Novel>> GetNovels();
        Task<IEnumerable<Novel>> UpsertNovels(List<Novel> newNovels);
    }
}