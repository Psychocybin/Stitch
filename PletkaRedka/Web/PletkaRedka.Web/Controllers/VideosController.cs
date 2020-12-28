namespace PletkaRedka.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using PletkaRedka.Common;
    using PletkaRedka.Services.Data;
    using PletkaRedka.Web.ViewModels.Categories;
    using PletkaRedka.Web.ViewModels.Videos;

    public class VideosController : Controller
    {
        private readonly IVideosService videosService;
        private readonly ICategoriesService categoriesService;

        public VideosController(
            IVideosService videosService,
            ICategoriesService categoriesService)
        {
            this.videosService = videosService;
            this.categoriesService = categoriesService;
        }

        [Authorize]
        public IActionResult Create()
        {
            var categories = this.categoriesService.GetAll<CategoryDropDownViewModel>();
            var viewModel = new CreateVideoInputModel
            {
                Categories = categories,
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateVideoInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.videosService.AddVideoAsync(input.Name, input.Description, input.VideoUrl, input.CategoryId);

            return this.RedirectToAction("ShowGalleries", "Galleries");
        }

        public IActionResult ShowAllVideos()
        {
            var viewModel = new ShowAllVideos
            {
                Videos = this.videosService.GetAll<VideoViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}
