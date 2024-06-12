using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Scraper.Contracts;

namespace Scraper.Base
{
    public abstract class ScraperBase : IScrape
    {
        public virtual Task ScrapeAsync()
        {
            throw new NotImplementedException();
        }
    }
}