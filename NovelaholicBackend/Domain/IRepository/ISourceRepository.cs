using Domain.Entities;

namespace Domain.IRepository
{
    public interface ISourceRepository
    {
        Task<Source> AddSource(Source source);
        Task<IEnumerable<Source>> GetSources();
    }
}