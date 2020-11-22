namespace PletkaRedka.Web.ViewModels.Categories
{
    using System.Collections.Generic;

    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public IEnumerable<PostInCategoryViewModel> Posts { get; set; }
    }
}
