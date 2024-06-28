using Domain.Entities;

namespace Domain.IRepository
{
    public interface IGenreRepository
    {
        Task<IEnumerable<Genre>> AddGenres(IEnumerable<Genre> newGenres);
        Task<IEnumerable<Genre>> GetGenres();
    }
}