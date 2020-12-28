namespace PletkaRedka.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using PletkaRedka.Data.Models;

    public interface IGaleriesService
    {
        Task<Gallery> AddPictureAsync(string description, string imageUrl, string userId, ApplicationUser user);

        IEnumerable<T> GetAllPictures<T>();

        IEnumerable<T> GetMyPictures<T>(string id);
    }
}
