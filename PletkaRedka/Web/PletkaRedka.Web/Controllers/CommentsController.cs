namespace PletkaRedka.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using PletkaRedka.Data.Common.Repositories;
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Data;
    using PletkaRedka.Web.ViewModels.Comments;

    public class CommentsController : Controller
    {
        private readonly ICommentsService commentsService;
        private readonly UserManager<ApplicationUser> userManager;

        public CommentsController(ICommentsService commentsService, UserManager<ApplicationUser> userManager)
        {
            this.commentsService = commentsService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult Input(int postId)
        {
            var viewModel = new CommentViewModel()
            {
                PostId = postId,
            };

            return this.View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(int postId, string content)
        {
            var userId = this.userManager.GetUserId(this.User);
            var viewModel = new CommentCreateInputModel
            {
                UserId = userId,
                PostId = postId,
                Content = content,
            };

            await this.commentsService.CreateAsync(viewModel.PostId, viewModel.UserId, viewModel.Content);
            return this.RedirectToAction("ById", "Posts", new { id = viewModel.PostId });
        }
    }
}
