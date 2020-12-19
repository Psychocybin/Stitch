namespace PletkaRedka.Web.ViewModels.Galleries
{
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;
    using System;
    using System.Collections.Generic;

    public class GetAllPicturesViewModel : IMapFrom<Gallery>
    {
        public int GalleryId { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
