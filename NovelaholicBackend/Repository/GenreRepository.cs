using Domain.Entities;
using Domain.IRepository;

namespace Repository
{
    public class GenreRepository : IGenreRepository
    {
        public Task<IEnumerable<Genre>> AddGenres(IEnumerable<Genre> newGenres)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Genre>> GetGenres()
        {
            throw new NotImplementedException();
        }
    }
}