namespace PletkaRedka.Web.ViewModels.Categories
{
    using System;

    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;

    public class PostInCategoryViewModel : IMapFrom<Post>
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public string ShortContent =>
            this.Content?.Length > 50
            ? this.Content?.Substring(0, 50) + "..."
            : this.Content;

        public string UserUserName { get; set; }

        public int CommentsCount { get; set; }
    }
}
