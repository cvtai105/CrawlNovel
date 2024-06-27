using Domain.Entities;
using Domain.IRepository;

namespace Repository
{
    public class GenreRepository : IGenreRepository
    {
        public Task<Genre> GetGenres()
        {
            throw new NotImplementedException();
        }

        public Task UpsertGenres(IEnumerable<Genre> genres)
        {
            throw new NotImplementedException();
        }
    }
}