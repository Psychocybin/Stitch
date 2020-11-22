namespace PletkaRedka.Web.ViewModels.Categories
{
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;

    public class PostInCategoryViewModel : IMapFrom<Post>
    {
        public string Name { get; set; }

        public string UserUserName { get; set; }

        public int CommentsCount { get; set; }
    }
}
