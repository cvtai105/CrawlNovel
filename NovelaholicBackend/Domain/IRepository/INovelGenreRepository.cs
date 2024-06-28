using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.IRepository
{
    public interface INovelGenreRepository
    {
        Task<IEnumerable<NovelGenre>> AddNovelGenres(int novelId, IEnumerable<Genre> genres);
    }
}