using Domain.Entities;
using Domain.IRepository;

namespace Repository
{
    public class NovelRepository : INovelRepository
    {
        public Task<IEnumerable<Novel>> AddNovels(IEnumerable<Novel> list)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Novel>> GetNovels()
        {
            throw new NotImplementedException();
        }
    }
}