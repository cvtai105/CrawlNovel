using Domain.Entities;

namespace Domain.IRepository
{
    public interface IGenreRepository
    {
        Task<IEnumerable<Genre>> GetGenres();
        Task<Genre> GetGenre(int id);
        Task<Genre> AddGenre(Genre genre);
        Task AddGenres(IEnumerable<Genre> genres);
        Task<Genre> UpdateGenre(Genre genre);
        Task<Genre> DeleteGenre(int id);
        
    }
}