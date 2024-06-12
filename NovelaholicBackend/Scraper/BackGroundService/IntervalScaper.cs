using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Scraper.Contracts;

namespace Scraper.BackGroundService
{
    public class IntervalScaper
    {
        private readonly IScrape _scrape;
        private readonly int _interval;

        public IntervalScaper(IScrape scrape, int interval)
        {
            _scrape = scrape;
            _interval = interval;
        }

        public async Task StartAsync()
        {
            while (true)
            {
                await _scrape.ScrapeAsync();
                await Task.Delay(TimeSpan.FromMinutes(_interval));
            }
        }
    }
}