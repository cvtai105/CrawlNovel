using Domain.Entities;
using Domain.IRepository;

namespace Repository
{
    public class ChapterRepository : IChapterRepository
    {
        public Task AddNovelChapters(int novelId, List<Chapter> chapters)
        {
            throw new NotImplementedException();
        }
    }
}