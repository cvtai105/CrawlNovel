using CrawlerTemplate.Base;
using Domain.Entities;
using Domain.IRepository;

namespace NovelaholicBackend.BackGroundCrawler
{
    public class CrawlServices
    {
        private CrawlerBase _crawlerBase;
        private IRepository _repository;
        public CrawlServices(CrawlerBase crawlerBase , IRepository repository)
        {
            _crawlerBase = crawlerBase;
            _repository = repository;
        }

        public async Task SeedData()
        {
            //seed source
            //seed genre
            //seed novel
        }

        private async Task SeedGenres()
        {
            var genres = await _crawlerBase.GetGenres();
            await _repository.GenreRepository.AddGenres(genres);
        }

        //assume Genres and Sources have been seeded
        private async Task SeedNovel()
        {
            var novels = await _crawlerBase.GetNovels();
            foreach (var novel in novels)
            {
                await _repository.NovelRepository.AddNovel(novel);
                
                
            }
        }

        private async Task SeedSource()
        {
            await _repository.SourceRepository.AddSource(_crawlerBase.Source);
        }

        public async Task UpdateData()
        {
            //check new novel and add to db
            //update like, view, rating, new chapter
            //update hotnovel   
        }

        

    }
}