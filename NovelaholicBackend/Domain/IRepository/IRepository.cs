using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface IRepository
    {
        IChapterRepository ChapterRepository { get; }
        IGenreRepository GenreRepository { get; }
        INovelRepository NovelRepository { get; }
        IChapterSourceRepository  ChapterSourceRepository { get; }
        ISourceRepository SourceRepository { get; }
        INovelSourceRepository NovelSourceRepository { get; }
        INovelGenreRepository NovelGenreRepository { get; }
    }
}