using System.Diagnostics.CodeAnalysis;
using Domain.Entities;

namespace BackGroundCrawler.Comparers
{
    public class NovelComparer : IEqualityComparer<Novel>
    {
        
        public bool Equals(Novel? x, Novel? y)
        {
            if (x == null || y == null)
            {
                return false;
            }

            return x.VietnameseTitle == y.VietnameseTitle;
        }

        public int GetHashCode([DisallowNull] Novel obj)
        {
            return obj.VietnameseTitle.GetHashCode();
        }
    }
}