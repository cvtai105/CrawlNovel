using CrawlerTemplate.Base;
using Microsoft.Extensions.Logging;
using Domain.IRepository;
using Domain.Entities;
using BackGroundCrawler.Comparers;

namespace NovelaholicBackend.BackGroundCrawler
{
    public class CrawlServices(CrawlerBase crawlerBase, IRepository repository, ILogger<CrawlServices> logger, IUnitOfWork unitOfWork)
    {
        private CrawlerBase _crawlerBase = crawlerBase;
        private IRepository _repository = repository;
        private IUnitOfWork _unitOfWork = unitOfWork;
        private ILogger _logger = logger;

        public async Task UpdateTask()
        {
            //TODO: omtimaise this method
            var updatedNovels = await _crawlerBase.GetNovels();
            await UpsertNovels(updatedNovels);
            AddIds(updatedNovels);
            foreach (var novel in updatedNovels)
            {
                await AddNewNovelSource(novel.Id, novel.NovelSources.First());
                await AddNovelChapters(novel.Id, novel.Chapters);
                AddIds(novel.Chapters);
                
                foreach (var chapter in novel.Chapters)
                {
                    await AddNewChapterSource(chapter.Id, chapter.ChapterSources.First());
                }
            }
        }

        private async Task AddNewChapterSource(int id, ChapterSource chapterSource)
        {
        }

        private void AddIds(List<Chapter> chapters)
        {
        }

        private void AddIds(IEnumerable<Novel> updatedNovels)
        {
        }

        private async Task UpsertNovels(IEnumerable<Novel> updatedNovels)
        {
            await AddNewNovels(updatedNovels);
            
        }

        public async Task StartupTask()
        {
            await AddGenres();
            await AddSource();
        } 
        
        private async Task AddGenres()
        {
            var genres = await _crawlerBase.GetGenres();
            var oldGenres = await _repository.GenreRepository.GetGenres();

            var newGenres = genres.Except(oldGenres, new GenreComparer());
            await _repository.GenreRepository.AddGenres(newGenres);
        }

        private async Task AddSource()
        {
            var source = _crawlerBase.Source;
            var oldSource = await _repository.SourceRepository.GetSources();
            if(!oldSource.Any(s => s.HostURL == source.HostURL))
            {
                await _repository.SourceRepository.AddSource(source);
            }
        }

        private async Task UpdateNovels(){
            var updatedNovels = await _crawlerBase.GetNovels();
            var oldNovels = await _repository.NovelRepository.GetNovels();
            var newNovels = FindNewNovels(updatedNovels, oldNovels);
            _ = await _repository.NovelRepository.UpsertNovels(newNovels);

            var novels = await _repository.NovelRepository.GetNovels();

            foreach(var n in novels){
                var findNovel = updatedNovels.FirstOrDefault(novel => novel.IsEquals(n));
                n.Chapters = findNovel.Chapters;
                foreach(var c in n.Chapters){
                    c.NovelId = n.Id;
                }
                n.NovelSources = findNovel.NovelSources;
                n.Genres = findNovel.Genres;

                _ = await _repository.NovelGenreRepository.AddNovelGenres(n.Id, n.Genres);
                var chapters = await _repository.ChapterRepository.UpsertChapters(n.Chapters);

            }


        

            foreach(var n in novels){
                var novelSource = n.NovelSources.First();
                if(novelSource != null){
                    novelSource.SourceId = _crawlerBase.Source.Id;
                    novelSource.NovelId = n.Id;
                    await _repository.NovelSourceRepository.AddNovelSource(novelSource);
                }

                var updatedChapters = n.Chapters;
                var oldChapters = await _unitOfWork.Repository.ChapterRepository.GetChapters(n.Id);
                var newChapters = FindNewChapters(updatedChapters, oldChapters);
                var chapters = await _unitOfWork.Repository.ChapterRepository.AddNovelChapters(n.Id, newChapters);    
                await _unitOfWork.CompleteAsync();

                foreach(var c in chapters){
                    var chapterSource = c.ChapterSources.First();
                    if(chapterSource != null){
                        chapterSource.SourceId = _crawlerBase.Source.Id;
                        chapterSource.ChapterId = c.Id;
                        await _repository.ChapterSourceRepository.AddChapterSource(chapterSource);
                    }
                }
        }
        }

        private async Task<IEnumerable<Chapter>> AddNovelChapters(int novelId, IEnumerable<Chapter> chapters)
        {
            var recentChapter = await _repository.ChapterRepository.GetLastChapter(novelId);

            var newChapters = chapters.Where(c => c.Number > recentChapter?.Number || recentChapter == null);

            newChapters = newChapters.Select(c =>
            {
                c.NovelId = novelId;
                return c;
            });

            return await _repository.ChapterRepository.AddChapters(newChapters);
        }

        private async Task<NovelSource> AddNewNovelSource(int novelId, NovelSource novelSource)
        {
            var source = await _repository.SourceRepository.GetSource(novelSource.SourceId);
            if (source == null)
            {
                await _repository.SourceRepository.UpsertSource(source);
            }
            return await _repository.NovelSourceRepository.AddNovelSource(novelId, novelSource);
        }

        private async Task<IEnumerable<Novel>> UpdateLikeViewRating(IEnumerable<Novel> novels){
            var updatedNovels = await _crawlerBase.GetNovels();
            var oldNovels = await _repository.NovelRepository.GetNovels();
            var newNovels = FindNewNovels(updatedNovels, oldNovels);
            _ = await _repository.NovelRepository.UpsertNovels(newNovels);

            var novels = await _repository.NovelRepository.GetNovels();

            foreach(var n in novels){
                var findNovel = updatedNovels.FirstOrDefault(novel => novel.IsEquals(n));
                n.Likes = findNovel.Likes;
                n.Views = findNovel.Views;
                n.Rating = findNovel.Rating;
            }
            return novels;
        }


        private async Task<List<Novel>> AddNewNovels(IEnumerable<Novel> novels)
        {
            await _unitOfWork.BeginTransactionAsync();
            try {
                var oldNovels = await _unitOfWork.Repository.NovelRepository.GetNovels();
                var newNovels = novels.Except(oldNovels, new NovelComparer()).ToList();
                var identifiedNovels = new List<Novel>(await _unitOfWork.Repository.NovelRepository.AddNovels(newNovels));
                await _unitOfWork.CompleteAsync();

                for (int i = 0; i < newNovels.Count; i++){
                    var novelGenres = newNovels[i].Genres;
                    var genres = await _unitOfWork.Repository.GenreRepository.GetGenres();
                    var identifiedGenres = genres.Where(g => novelGenres.Any(ng => ng.Name == g.Name)).ToList();

                    _ = await _unitOfWork.Repository.NovelGenreRepository.AddNovelGenres(newNovels[i].Id, identifiedGenres);
                }
                await _unitOfWork.CompleteAsync();
                await _unitOfWork.CommitTransactionAsync();
                return identifiedNovels;
            } catch (Exception e) {
                await _unitOfWork.RollbackTransactionAsync();
                _logger.LogError(e, "Error while adding new novels");
                return [];
            }
        }

        private List<Chapter> FindNewChapters(IEnumerable<Chapter> updatedChapters, IEnumerable<Chapter> oldChapters)
        {
            var newChapters = new List<Chapter>();
            foreach (var chapter in updatedChapters)
            {
                if (!oldChapters.Any(c => c.Number == chapter.Number && c.NovelId == chapter.NovelId))
                {
                    newChapters.Add(chapter);
                }
            }
            return newChapters;
        }

    }
}