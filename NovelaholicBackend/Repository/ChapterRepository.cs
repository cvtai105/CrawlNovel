using Domain.Entities;
using Domain.IRepository;

namespace Repository
{
    public class ChapterRepository : IChapterRepository
    {
        public Task<IEnumerable<Chapter>> AddChapters(IEnumerable<Chapter> chapters)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Chapter>> AddNovelChapters(int novelId, List<Chapter> chapters)
        {
            throw new NotImplementedException();
        }

         public Task<Chapter?> GetLastChapter(int novelId)
        {
            throw new NotImplementedException();
        }
    }
}