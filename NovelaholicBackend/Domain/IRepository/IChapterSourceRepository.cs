using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public class IChapterSourceRepository
    {
        Task<IEnumerable<ChapterSource>> GetChapterSources();
        Task<ChapterSource> GetChapterSource(int id);
        Task<ChapterSource> AddChapterSource(ChapterSource chapterSource);
        Task<ChapterSource> UpdateChapterSource(ChapterSource chapterSource);
        Task<ChapterSource> DeleteChapterSource(int id);
           
    }
}