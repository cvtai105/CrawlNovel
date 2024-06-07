using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public class IChapterRepository
    {
        Task<IEnumerable<Chapter>> GetChapters();
        Task<Chapter> GetChapter(int id);
        Task<Chapter> AddChapter(Chapter chapter);
        Task<Chapter> UpdateChapter(Chapter chapter);
        Task<Chapter> DeleteChapter(int id);
    }
}