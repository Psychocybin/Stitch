namespace PletkaRedka.Web.ViewModels.Galleries
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;

    public class AddPictureViewModel : IMapFrom<Gallery>
    {
        public string UserId { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(200)]
        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserUserName { get; set; }
    }
}
