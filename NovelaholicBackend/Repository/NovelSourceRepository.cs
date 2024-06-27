using Domain.Entities;
using Domain.IRepository;

namespace Repository
{
    public class NovelSourceRepository : INovelSourceRepository
    {
        public Task AddNovelSource(NovelSource novelSource)
        {
            throw new NotImplementedException();
        }
    }
}