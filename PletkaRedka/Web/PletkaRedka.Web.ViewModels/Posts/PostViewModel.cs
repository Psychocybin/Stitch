namespace PletkaRedka.Web.ViewModels.Posts
{
    using System;

    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;

    public class PostViewModel : IMapFrom<Post>
    {
        public DateTime CreatedOn { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public string UserUserName { get; set; }
    }
}
