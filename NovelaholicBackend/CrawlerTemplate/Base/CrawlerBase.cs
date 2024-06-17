using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrawlerTemplate.DTOs;
using ICrawler;

namespace CrawlerTemplate.Base
{
    public abstract class CrawlerBase : ICrawlGenres, ICrawlNovels, ICrawlHotNovels, ICrawlUpdateds
    {
        protected abstract string GenreUrl { get; set; } 
        protected string HotNovelListUrl { get; set; } = String.Empty;
        protected string NovelUrl { get; set; } = String.Empty;
        protected string UpdatedUrl { get; set; } = String.Empty;

        public async Task<IEnumerable<GenreDTO>> GetGenres(){
            string data = await GetUrlData(GenreUrl);
            return ParseGenres(data);
        }

        private IEnumerable<GenreDTO> ParseGenres(string data)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HotNovelDTO>> GetHotNovels()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<NovelInfoDTO>> GetNovels()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<NovelUpdateDTO>> GetUpdateds()
        {
            throw new NotImplementedException();
        }

        protected IEnumerable<string> GetNovelUrls()
        {
            throw new NotImplementedException();
        }

        protected Task<string> GetUrlData(string url)
        {
            throw new NotImplementedException();
        }
    }
}