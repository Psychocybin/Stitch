namespace PletkaRedka.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using PletkaRedka.Data.Common.Repositories;
    using PletkaRedka.Data.Models;
    using System.Linq;
    using PletkaRedka.Services.Mapping;

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

        public IEnumerable<T> GetAllPictures<T>()
        {
            IQueryable<Gallery> query = this.repository.All().OrderByDescending(x => x.Id);
            return query.To<T>().ToList();
        }

        public IEnumerable<T> GetMyPictures<T>(string id)
        {
            IQueryable<Gallery> query = this.repository.All()
                .Where(x => x.UserId == id).OrderByDescending(x => x.Id);
            return query.To<T>().ToList();
        }
    }
}
