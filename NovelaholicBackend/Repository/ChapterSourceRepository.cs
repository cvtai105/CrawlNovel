using Domain.Entities;
using Domain.IRepository;

namespace Repository
{
    public class ChapterSourceRepository : IChapterSourceRepository
    {
        public Task<ChapterSource> AddChapterSource(ChapterSource chapterSource)
        {
            throw new NotImplementedException();
        }

        public Task<ChapterSource> DeleteChapterSource(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ChapterSource> GetChapterSource(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ChapterSource>> GetChapterSources()
        {
            throw new NotImplementedException();
        }

        public Task<ChapterSource> UpdateChapterSource(ChapterSource chapterSource)
        {
            throw new NotImplementedException();
        }
    }
}