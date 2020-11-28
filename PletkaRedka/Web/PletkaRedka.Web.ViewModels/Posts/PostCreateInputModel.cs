namespace PletkaRedka.Web.ViewModels.Posts
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using PletkaRedka.Web.ViewModels.Categories;

    public class PostCreateInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }

        [Display(Name = "Категория")]
        public int CategoryId { get; set; }

        public IEnumerable<CategoryDropDownViewModel> Categories { get; set; }
    }
}
