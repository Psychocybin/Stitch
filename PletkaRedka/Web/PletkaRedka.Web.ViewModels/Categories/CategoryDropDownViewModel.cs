namespace PletkaRedka.Web.ViewModels.Categories
{
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;

    public class CategoryDropDownViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
