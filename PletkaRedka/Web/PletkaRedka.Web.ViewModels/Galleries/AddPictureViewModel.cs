namespace PletkaRedka.Web.ViewModels.Galleries
{
    using System;

    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;

    public class AddPictureViewModel : IMapFrom<Gallery>
    {
        public string UserId { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserUserName { get; set; }
    }
}
