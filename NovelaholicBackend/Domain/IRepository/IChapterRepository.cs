using Domain.Entities;

namespace Domain.IRepository
{
    public interface IChapterRepository
    {       
        Task AddNovelChapters(int novelId, List<Chapter> chapters);
    }
}