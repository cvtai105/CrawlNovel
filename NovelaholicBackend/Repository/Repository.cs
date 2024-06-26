using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.IRepository;

namespace Repository
{
    public class Repository : IRepository
    {
        public IChapterRepository ChapterRepository => new ChapterRepository();

        public IGenreRepository GenreRepository => new GenreRepository();

        public INovelRepository NovelRepository => new NovelRepository();

        public IChapterSourceRepository ChapterSourceRepository => new ChapterSourceRepository();

        public ISourceRepository SourceRepository => new SourceRepository();

        public INovelSourceRepository NovelSourceRepository => new NovelSourceRepository();

        public INovelGenreRepository NovelGenreRepository => new NovelGenreRepository();
    }

}