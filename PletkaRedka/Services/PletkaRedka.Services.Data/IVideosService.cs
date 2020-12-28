namespace PletkaRedka.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IVideosService
    {
        Task<int> AddVideoAsync(string name, string description, string videoUrl, int categoryId);

        IEnumerable<T> GetAll<T>();

        IEnumerable<T> GetById<T>(int categoryId);
    }
}
