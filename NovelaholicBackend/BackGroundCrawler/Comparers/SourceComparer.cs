using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace BackGroundCrawler.Comparers
{
    public class SourceComparer : IEqualityComparer<Source>
    {
        public bool Equals(Source? x, Source? y)
        {
            if (x == null && y == null)
            {
                return true;
            }
            else if (x == null || y == null)
            {
                return false;
            }
            else
            {
                return x.HostURL == y.HostURL;
            }
        }

        public int GetHashCode(Source obj)
        {
            return obj.HostURL.GetHashCode();
        }
        
    }
}