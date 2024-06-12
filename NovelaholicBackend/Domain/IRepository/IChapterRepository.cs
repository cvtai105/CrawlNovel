using Domain.Entities;

namespace Domain.IRepository
{
    public interface IChapterRepository
    {
        Task<IEnumerable<Chapter>> GetChapters();
        Task<Chapter> GetChapter(int id);
        Task<Chapter> AddChapter(Chapter chapter);
        Task<Chapter> UpdateChapter(Chapter chapter);
        Task<Chapter> DeleteChapter(int id);
    }
}