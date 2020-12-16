namespace PletkaRedka.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using PletkaRedka.Data.Common.Repositories;
    using PletkaRedka.Data.Models;

    public class GaleriesService : IGaleriesService
    {
        private readonly IDeletableEntityRepository<Gallery> repository;

        public GaleriesService(IDeletableEntityRepository<Gallery> repository)
        {
            this.repository = repository;
        }

        public async Task<Gallery> AddPictureAsync(string description, string imageUrl, string userId, ApplicationUser user)
        {
            var picture = new Gallery()
            {
                Description = description,
                ImageUrl = imageUrl,
                UserId = userId,
            };

            user.Galleries.Add(picture);
            await this.repository.AddAsync(picture);
            await this.repository.SaveChangesAsync();

            return picture;
        }

    }
}
