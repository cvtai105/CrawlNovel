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
        public Task AddNovelGenres(int id, IEnumerable<Genre> genres)
        {
            throw new NotImplementedException();
        }
    }
}