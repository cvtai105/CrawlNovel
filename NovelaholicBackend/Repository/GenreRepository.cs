using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Entities;
using Common.IRepository;

namespace Repository
{
    public class GenreRepository : IGenreRepository
    {
        public Task<Genre> AddGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        public Task<Genre> DeleteGenre(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Genre> GetGenre(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Genre>> GetGenres()
        {
            throw new NotImplementedException();
        }

        public Task<Genre> UpdateGenre(Genre genre)
        {
            throw new NotImplementedException();
        }
    }
}