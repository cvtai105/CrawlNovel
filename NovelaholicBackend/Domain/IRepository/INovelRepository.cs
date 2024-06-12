using Domain.Entities;

namespace Domain.IRepository
{
    public interface INovelRepository
    {
        Task<IEnumerable<Novel>> GetNovels();
        Task<Novel> GetNovel(int id);
        Task<Novel> AddNovel(Novel novel);
        Task<Novel> UpdateNovel(Novel novel);
        Task<Novel> DeleteNovel(int id);
        
    }
}