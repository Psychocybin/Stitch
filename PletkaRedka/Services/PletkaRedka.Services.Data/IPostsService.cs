﻿namespace PletkaRedka.Services.Data
{
    using System.Threading.Tasks;

    public interface IPostsService
    {
        Task<int> CreateAsync(string name, string content, int categoryId, string userId);
    }
}