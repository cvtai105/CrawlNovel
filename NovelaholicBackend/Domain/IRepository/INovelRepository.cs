using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public class INovelRepository
    {
        Task<IEnumerable<Novel>> GetNovels();
        Task<Novel> GetNovel(int id);
        Task<Novel> AddNovel(Novel novel);
        Task<Novel> UpdateNovel(Novel novel);
        Task<Novel> DeleteNovel(int id);
        
    }
}