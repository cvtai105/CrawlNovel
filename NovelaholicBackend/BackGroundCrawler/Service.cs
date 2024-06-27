using CrawlerTemplate.Base;
using Microsoft.Extensions.Logging;
using Domain.IRepository;
using Domain.Entities;

namespace NovelaholicBackend.BackGroundCrawler
{
    public class CrawlServices
    {
        private CrawlerBase _crawlerBase;
        private IRepository _repository;
        private IUnitOfWork _unitOfWork;
        private ILogger _logger;
        public CrawlServices(CrawlerBase crawlerBase , IRepository repository, ILogger<CrawlServices> logger, IUnitOfWork unitOfWork)
        {
            _crawlerBase = crawlerBase;
            _repository = repository;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
      
        public async Task UpdateData()
        {
            
        }

        public async Task StartupTask()
        {
            await UpsertGenre();
            await UpsertSource();
            await UpdateNovels();
        } 
        
        private async Task UpsertGenre()
        {
            var genres = await _crawlerBase.GetGenres();
            await _repository.GenreRepository.UpsertGenres(genres);
        }

        private async Task UpsertSource()
        {
            await _repository.SourceRepository.UpsertSource(_crawlerBase.Source);
        }

        private async Task UpdateNovels(){
            var updatedNovels = await _crawlerBase.GetNovels();
            var oldNovels = await _repository.NovelRepository.GetNovels();
            var newNovels = FindNewNovels(updatedNovels, oldNovels);
            //add new novels and novelurl
            var novels = await _repository.NovelRepository.AddNovels(newNovels);
            foreach(var n in novels){
                var novelSource = n.NovelSources.First();
                if(novelSource != null){
                    novelSource.SourceId = _crawlerBase.Source.Id;
                    novelSource.NovelId = n.Id;
                    await _repository.NovelSourceRepository.AddNovelSource(novelSource);
                }
            }
            //add new chapter each novel

        }

        private List<Novel> FindNewNovels(IEnumerable<Novel> updatedNovels, IEnumerable<Novel> oldNovels)
        {
            var newNovels = new List<Novel>();
            foreach (var novel in updatedNovels)
            {
                if (!oldNovels.Any(n => n.IsEquals(novel)))
                {
                    newNovels.Add(novel);
                }
            }
            return newNovels;
        }
    }
}