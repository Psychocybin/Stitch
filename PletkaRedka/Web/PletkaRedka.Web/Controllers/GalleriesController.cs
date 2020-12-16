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

            var picture = new Gallery()
            {
                Description = input.Description,
                ImageUrl = input.ImageUrl,
                UserId = user.Id,
            };

            picture = await this.galeriesService.AddPictureAsync(picture.Description, picture.ImageUrl, picture.UserId, user);
            user.Galleries.Add(picture);

            return this.RedirectToAction("ShowGalleries", "Galleries");
        }

        public IActionResult ShowAllPictures()
        {
            var viewModel = new GetAllPicturesViewModel();

            return this.View(viewModel);
        }
    }
}
