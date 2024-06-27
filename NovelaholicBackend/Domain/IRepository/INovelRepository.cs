using Domain.Entities;

namespace Domain.IRepository
{
    public interface INovelRepository
    {
        Task<IEnumerable<Novel>> AddNovels(IEnumerable<Novel> list);
        Task<IEnumerable<Novel>> GetNovels();
    }
}