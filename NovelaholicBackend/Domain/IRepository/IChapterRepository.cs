using Domain.Entities;

namespace Domain.IRepository
{
    public interface IChapterRepository
    {       
        Task<IEnumerable<Chapter>> AddChapters(IEnumerable<Chapter> chapters);
        Task<Chapter?> GetLastChapter(int novelId);
    }
}