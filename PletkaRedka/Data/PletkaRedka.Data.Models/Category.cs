﻿namespace PletkaRedka.Data.Models
{
    using System.Collections.Generic;

    using PletkaRedka.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Posts = new HashSet<Post>();
            this.Videos = new HashSet<Video>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Video> Videos { get; set; }
    }
}
