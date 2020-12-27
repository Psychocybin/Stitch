namespace PletkaRedka.Web.ViewModels.Videos
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;
    using PletkaRedka.Web.ViewModels.Categories;

    public class CreateVideoInputModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public string VideoUrl { get; set; }

        public int CategoryId { get; set; }

        public IEnumerable<CategoryDropDownViewModel> Categories { get; set; }
    }
}
