namespace PletkaRedka.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;
    using PletkaRedka.Data.Common.Repositories;
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Data;
    using PletkaRedka.Services.Mapping;
    using PletkaRedka.Web.ViewModels;
    using PletkaRedka.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly ICategoriesService categoriesService;

        public HomeController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            var categories = this.categoriesService.GetAll<IndexCategoryViewModel>();
            viewModel.Categories = categories;

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        public IActionResult About()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
