namespace PletkaRedka.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Data;

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
            return View();
        }
    }
}
