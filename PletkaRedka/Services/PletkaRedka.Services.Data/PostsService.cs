namespace PletkaRedka.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using PletkaRedka.Data.Common.Repositories;
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;

    public class PostsService : IPostsService
    {
        private readonly IDeletableEntityRepository<Post> postsRepository;

        public PostsService(IDeletableEntityRepository<Post> postsRepository)
        {
            this.postsRepository = postsRepository;
        }

        public async Task<int> CreateAsync(string name, string content, int categoryId, string userId)
        {
            var post = new Post
            {
                Name = name,
                Content = content,
                CategoryId = categoryId,
                UserId = userId,
            };

            await this.postsRepository.AddAsync(post);
            await this.postsRepository.SaveChangesAsync();
            return post.Id;
        }

        public T GetById<T>(int id)
        {
            var post = this.postsRepository.All().Where(x => x.Id == id)
                .To<T>().FirstOrDefault();
            return post;
        }
    }
}
