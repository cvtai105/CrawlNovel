using Domain.Entities;
using Domain.IRepository;

namespace Repository
{
    public class NovelRepository : INovelRepository
    {
        public Task<Novel> AddNovel(Novel novel)
        {
            throw new NotImplementedException();
        }

        public Task<Novel> DeleteNovel(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Novel> GetNovel(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Novel>> GetNovels()
        {
            throw new NotImplementedException();
        }

        public Task<Novel> UpdateNovel(Novel novel)
        {
            throw new NotImplementedException();
        }
    }
}