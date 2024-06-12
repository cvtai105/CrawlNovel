using Domain.Entities;

namespace Domain.IRepository
{
    public interface ISourceRepository
    {
        Task<IEnumerable<Source>> GetSources();
        Task<Source> GetSource(int id);
        Task<Source> AddSource(Source source);
        Task<Source> UpdateSource(Source source);
        Task<Source> DeleteSource(int id);
    }
}