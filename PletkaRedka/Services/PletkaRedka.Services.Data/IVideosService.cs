using PletkaRedka.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PletkaRedka.Services.Data
{
    public interface IVideosService
    {
        Task<int> AddVideoAsync(string name, string description, string videoUrl, int categoryId);
    }
}
