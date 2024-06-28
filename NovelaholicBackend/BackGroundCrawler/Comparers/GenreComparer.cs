using System.Diagnostics.CodeAnalysis;
using Domain.Entities;

namespace BackGroundCrawler.Comparers
{
    public class GenreComparer : IEqualityComparer<Genre>
    {
        public bool Equals(Genre? x, Genre? y)
        {
            if (x == null || y == null)
            {
                return false;
            }

            return x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Genre obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}