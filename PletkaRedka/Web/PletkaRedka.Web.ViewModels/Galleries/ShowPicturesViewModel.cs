namespace PletkaRedka.Web.ViewModels.Galleries
{
    using System;

    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;

    public class ShowPicturesViewModel : IMapFrom<ApplicationUser>
    {
        public string GalleriesUserId { get; set; }

        public string GalleriesUserName { get; set; }

        public DateTime GalleriesCreatedOn { get; set; }

        public string GalleriesDescription { get; set; }

        public string GalleriesImageUrl { get; set; }
    }
}
