using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace ILnWebReader
{
    public interface IHomePageReader
    {
        Task<IEnumerable<Novel>> GetHotNovels();
    }
}