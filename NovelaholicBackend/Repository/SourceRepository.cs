using Domain.Entities;
using Domain.IRepository;

namespace Repository
{
    public class SourceRepository : ISourceRepository
    {
        public Task UpsertSource(Source source)
        {
            throw new NotImplementedException();
        }
    }
}