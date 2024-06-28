using Domain.Entities;
using Domain.IRepository;

namespace Repository
{
    public class SourceRepository : ISourceRepository
    {
        public Task<Source> AddSource(Source source)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Source>> GetSources()
        {
            throw new NotImplementedException();
        }
    }
}