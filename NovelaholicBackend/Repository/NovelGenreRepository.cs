using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.IRepository;

namespace Repository
{
    public class NovelGenreRepository : INovelGenreRepository
    {
        public Task<IEnumerable<NovelGenre>> AddNovelGenres(int novelId, IEnumerable<Genre> genres)
        {
            throw new NotImplementedException();
        }
    }
}