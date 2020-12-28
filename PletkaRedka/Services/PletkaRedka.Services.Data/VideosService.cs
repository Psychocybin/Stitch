namespace PletkaRedka.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PletkaRedka.Data.Common.Repositories;
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;

    public class VideosService : IVideosService
    {
        private readonly IDeletableEntityRepository<Video> videoRepository;

        public VideosService(IDeletableEntityRepository<Video> videoRepository)
        {
            this.videoRepository = videoRepository;
        }

        public async Task<int> AddVideoAsync(string name, string description, string videoUrl, int categoryId)
        {
            string youtubeVideo = MakeYoutubeVideo(videoUrl);

            var video = new Video
            {
                Name = name,
                Description = description,
                VideoUrl = youtubeVideo.ToString().TrimEnd(),
                CategoryId = categoryId,
            };

            await this.videoRepository.AddAsync(video);
            await this.videoRepository.SaveChangesAsync();

            return video.Id;
        }

        public IEnumerable<T> GetAll<T>()
        {
            IQueryable<Video> query = this.videoRepository.All().OrderByDescending(x => x.Id);
            return query.To<T>().ToList();
        }

        private static string MakeYoutubeVideo(string videoInput)
        {
            var sb = new StringBuilder();
            sb.Append("https://www.youtube.com/embed/");
            var splitedVideoUrl = videoInput.Split("watch?v=");
            sb.Append(splitedVideoUrl[1]);
            sb.Append("?autoplay=0");
            var youtubeVideo = sb.ToString().TrimEnd();
            return youtubeVideo;
        }
    }
}
