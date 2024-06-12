using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace ILnWebReader
{
    public interface INovelInFoPageReader
    {
        Task<Novel> GetNovelInfo(string novelUrl);
    }
}