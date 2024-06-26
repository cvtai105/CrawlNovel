using CrawlerTemplate.Base;

namespace NovelaholicBackend.BackGroundCrawler
{
    public class CrawlServices
    {
        private CrawlerBase _crawlerBase;
        public CrawlServices(CrawlerBase crawlerBase)
        {
            _crawlerBase = crawlerBase;
        }
    }
}