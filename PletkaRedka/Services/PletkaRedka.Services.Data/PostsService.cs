﻿namespace PletkaRedka.Services.Data
{
    using System.Threading.Tasks;

    using PletkaRedka.Data.Common.Repositories;
    using PletkaRedka.Data.Models;

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
    }
}