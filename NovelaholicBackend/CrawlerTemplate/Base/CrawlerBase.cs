using Domain.Entities;
using ICrawler;

//This class provide method to crawl genres, novels and hot novels

namespace CrawlerTemplate.Base
{
    public abstract class CrawlerBase : ICrawlGenres, ICrawlNovels, ICrawlHotNovels
    {
        public abstract Source Source { get; protected set;}
        public static async Task<string> GetUrlData(string url)
        {
            using HttpClient client = new();
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseData = await response.Content.ReadAsStringAsync();
                return responseData;
            }
            catch (HttpRequestException e)
            {
                throw new InvalidOperationException("Error fetching data from the URL", e);
            }
        }

        /// <summary>
        /// Url to get the list of novels sorted by update date
        /// </summary>
        /// <value></value>

        public async Task<IEnumerable<Genre>> GetGenres(){
            string data = await GetUrlData(Source.GenreUrl);
            return ParseGenres(data);
        }
        public async Task<IEnumerable<Novel>> GetHotNovels()
        {   
            string data = await GetUrlData(Source.HotNovelUrl);
            var links = ParseHotNovelLinks(data);
            return await GetNovels(links);
        }
        public async Task<IEnumerable<Novel>> GetNovels()
        {
            string page = await GetUrlData(Source.NovelListUrl);
            List<string> novelUrls = ParseNovelLinks(page);

            return await GetNovels(novelUrls);
        }
        public async Task<IEnumerable<Novel>> GetNovels(IEnumerable<string> urls){ 
            var novelInfos = new List<Novel>();
            foreach (var url in urls)
            {
                string data = await GetUrlData(url);
                var novelInfo = ParseNovelInfo(data);
                novelInfos.Add(novelInfo);
            }
            return novelInfos;
        }

        protected abstract IEnumerable<Genre> ParseGenres(string data);

        protected abstract Novel ParseNovelInfo(string data);

        protected abstract List<string> ParseNovelLinks(string page);

        private IEnumerable<string> ParseHotNovelLinks(string data)
        {
            throw new NotImplementedException();
        }
        protected abstract IEnumerable<Novel> ParseHotNovels(string data);
    }
}