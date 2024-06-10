using Common.Entities;

namespace Common.IRepository
{
    public interface IGenreRepository
    {
        Task<IEnumerable<Genre>> GetGenres();
        Task<Genre> GetGenre(int id);
        Task<Genre> AddGenre(Genre genre);
        Task<Genre> UpdateGenre(Genre genre);
        Task<Genre> DeleteGenre(int id);
        
    }
}