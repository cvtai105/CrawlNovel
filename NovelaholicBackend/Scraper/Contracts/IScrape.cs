using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scraper.Contracts
{
    public interface IScrape
    {
        Task ScrapeAsync();
    }
}