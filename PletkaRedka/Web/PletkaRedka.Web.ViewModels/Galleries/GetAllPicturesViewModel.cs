namespace PletkaRedka.Web.ViewModels.Galleries
{
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;
    using System.Collections.Generic;

    public class GetAllPicturesViewModel
    {
        public virtual IEnumerable<ShowPicturesViewModel> Galleries { get; set; }
    }
}
