namespace PletkaRedka.Services.Data
{
    using System.Threading.Tasks;

    using PletkaRedka.Data.Models;

    public interface IGaleriesService
    {
        Task<Gallery> AddPictureAsync(string description, string imageUrl, string userId, ApplicationUser user);
    }
}
