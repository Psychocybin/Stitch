namespace PletkaRedka.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Data;
    using PletkaRedka.Web.ViewModels.Galleries;

    public class GalleriesController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IGaleriesService galeriesService;

        public GalleriesController(UserManager<ApplicationUser> userManager, IGaleriesService galeriesService)
        {
            this.userManager = userManager;
            this.galeriesService = galeriesService;
        }

        public IActionResult ShowGalleries()
        {
            return this.View("Gallery");
        }

        [Authorize]
        public IActionResult AddPictureForm()
        {
            return this.View("AddPictureForm");
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddPicture(AddPictureViewModel input)
        {
            var user = await this.userManager.GetUserAsync(this.User);

            var picture = await this.galeriesService.AddPictureAsync(input.Description, input.ImageUrl, input.UserId, user);
            user.Galleries.Add(picture);

            return this.RedirectToAction("ShowGalleries", "Galleries");
        }

        public IActionResult ShowAllPictures()
        {
            var viewModel = new ShowPicturesViewModel()
            {
                Galleries = this.galeriesService.GetAllPictures<GetAllPicturesViewModel>(),
            };
            return this.View(viewModel);
        }
    }
}
