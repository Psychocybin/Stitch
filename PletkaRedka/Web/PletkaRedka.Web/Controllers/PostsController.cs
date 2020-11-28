namespace PletkaRedka.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Data;
    using PletkaRedka.Web.ViewModels.Categories;
    using PletkaRedka.Web.ViewModels.Posts;

    public class PostsController : Controller
    {
        private readonly IPostsService postsService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ICategoriesService categoriesService;

        public PostsController(
            IPostsService postsService,
            UserManager<ApplicationUser> userManager,
            ICategoriesService categoriesService)
        {
            this.postsService = postsService;
            this.userManager = userManager;
            this.categoriesService = categoriesService;
        }

        public IActionResult ById(int id)
        {
            return this.View();
        }

        [Authorize]
        public IActionResult Create()
        {
            var categories = this.categoriesService.GetAll<CategoryDropDownViewModel>();
            var viewModel = new PostCreateInputModel
            {
                Categories = categories,
            };
            return this.View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(PostCreateInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var user = await this.userManager.GetUserAsync(this.User);

            var postId = await this.postsService.CreateAsync(input.Name, input.Content, input.CategoryId, user.Id);
            return this.RedirectToAction("ById", new { id = postId });
        }
    }
}
