using Common.Entities;

namespace Common.IRepository
{
    public interface IChapterSourceRepository
    {
        Task<IEnumerable<ChapterSource>> GetChapterSources();
        Task<ChapterSource> GetChapterSource(int id);
        Task<ChapterSource> AddChapterSource(ChapterSource chapterSource);
        Task<ChapterSource> UpdateChapterSource(ChapterSource chapterSource);
        Task<ChapterSource> DeleteChapterSource(int id);
           
    }
}