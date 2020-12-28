namespace PletkaRedka.Web.ViewModels.Videos
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using PletkaRedka.Web.ViewModels.Categories;

    public class SelectCategoryViewModel
    {
        [Display(Name = "Категория")]
        public int CategoryId { get; set; }

        public IEnumerable<CategoryDropDownViewModel> Categories { get; set; }
    }
}
