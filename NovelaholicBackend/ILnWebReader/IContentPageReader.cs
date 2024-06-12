using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ILnWebReader
{
    public interface IContentPageReader
    {
        Task<string> GetContent(string contentUrl);
    }
}