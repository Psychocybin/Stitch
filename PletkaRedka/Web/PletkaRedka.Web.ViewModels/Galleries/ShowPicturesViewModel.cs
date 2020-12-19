namespace PletkaRedka.Web.ViewModels.Galleries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;

    public class ShowPicturesViewModel
    {
        public IEnumerable<GetAllPicturesViewModel> Galleries { get; set; }
    }
}
