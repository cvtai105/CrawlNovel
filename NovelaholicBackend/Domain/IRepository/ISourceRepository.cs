using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public class ISourceRepository
    {
        Task<IEnumerable<Source>> GetSources();
        Task<Source> GetSource(int id);
        Task<Source> AddSource(Source source);
        Task<Source> UpdateSource(Source source);
        Task<Source> DeleteSource(int id);
    }
}