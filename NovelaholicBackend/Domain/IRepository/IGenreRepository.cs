using Domain.Entities;

namespace Domain.IRepository
{
    public interface IGenreRepository
    {
        Task<Genre> GetGenres();
        Task UpsertGenres(IEnumerable<Genre> genres);
    }
}