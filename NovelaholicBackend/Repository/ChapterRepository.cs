using Domain.Entities;
using Domain.IRepository;

namespace Repository
{
    public class ChapterRepository : IChapterRepository
    {

        public Task<Chapter> AddChapter(Chapter chapter)
        {
            throw new NotImplementedException();
        }

        public Task<Chapter> DeleteChapter(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Chapter> GetChapter(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Chapter>> GetChapters()
        {
            throw new NotImplementedException();
        }

        public Task<Chapter> UpdateChapter(Chapter chapter)
        {
            throw new NotImplementedException();
        }
    }
}