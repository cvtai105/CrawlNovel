using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrawlerTemplate.DTOs;
using ICrawler;

namespace CrawlerTemplate.Base
{
    public abstract class CrawlerBase : ICrawlGenres, ICrawlNovels, ICrawlHotNovels
    {
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
        protected abstract string GenreUrl { get; set; } 
        protected abstract string HotNovelListUrl { get; set; } 

        /// <summary>
        /// Url to get the list of novels sorted by update date
        /// </summary>
        /// <value></value>
        protected abstract string NovelListUrl { get; set; } 

        public async Task<IEnumerable<string>> GetGenres(){
            string data = await GetUrlData(GenreUrl);
            return ParseGenres(data);
        }
        public async Task<IEnumerable<NovelInfoDTO>> GetHotNovels()
        {   
            string data = await GetUrlData(HotNovelListUrl);
            var links = ParseHotNovelLinks(data);
            
            return await GetNovels(links);
        }

        public async Task<IEnumerable<NovelInfoDTO>> GetNovels(IEnumerable<string> urls){ 
            var novelInfos = new List<NovelInfoDTO>();
            foreach (var url in urls)
            {
                string data = await GetUrlData(url);
                var novelInfo = ParseNovelInfo(data);
                novelInfos.Add(novelInfo);
            }
            return novelInfos;
        }

        private IEnumerable<string> ParseHotNovelLinks(string data)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<NovelInfoDTO>> GetNovels()
        {
            string page = await GetUrlData(NovelListUrl);
            List<string> novelUrls = ParseNovelLinks(page);

            return await GetNovels(novelUrls);
        }

        private NovelInfoDTO ParseNovelInfo(string data)
        {
            throw new NotImplementedException();
        }

        private List<string> ParseNovelLinks(string page)
        {
            throw new NotImplementedException();
        }

        
        protected IEnumerable<string> GetNovelUrls()
        {
            throw new NotImplementedException();
        }

        

        protected abstract IEnumerable<string> ParseGenres(string data);
        protected abstract IEnumerable<NovelInfoDTO> ParseHotNovels(string data);
    }
}