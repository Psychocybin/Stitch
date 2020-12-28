using System;
using System.Collections.Generic;
using System.Text;

namespace PletkaRedka.Web.ViewModels.Galleries
{
    public class ShowMyPicturesViewModel
    {
        public IEnumerable<GetAllPicturesViewModel> Galleries { get; set; }
    }
}
