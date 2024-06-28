using Domain.Entities;
using Domain.IRepository;

namespace Repository
{
    public class NovelRepository : INovelRepository
    {
        public Task<IEnumerable<Novel>> AddNovels(IEnumerable<Novel> newNovels)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Novel>> GetNovels()
        {
            throw new NotImplementedException();
        }


        Task<IEnumerable<Novel>> INovelRepository.UpsertNovels(List<Novel> newNovels)
        {
            throw new NotImplementedException();
        }
    }
}