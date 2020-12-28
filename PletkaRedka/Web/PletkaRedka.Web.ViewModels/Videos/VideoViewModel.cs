using PletkaRedka.Data.Models;
using PletkaRedka.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace PletkaRedka.Web.ViewModels.Videos
{
    public class VideoViewModel : IMapFrom<Video>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string VideoUrl { get; set; }

        public int CategoryId { get; set; }
    }
}
