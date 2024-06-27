
using Domain.Entities;

namespace Domain.IRepository
{
    public interface INovelSourceRepository
    {
        Task AddNovelSource(NovelSource novelSource);
    }
}