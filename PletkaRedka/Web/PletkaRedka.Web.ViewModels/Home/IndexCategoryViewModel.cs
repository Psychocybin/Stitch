namespace PletkaRedka.Web.ViewModels.Home
{
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;

    public class IndexCategoryViewModel : IMapFrom<Category>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string Url => $"/c/{this.Name.Replace(' ', '-')}";
    }
}