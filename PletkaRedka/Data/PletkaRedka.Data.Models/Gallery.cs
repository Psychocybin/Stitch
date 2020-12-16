namespace PletkaRedka.Data.Models
{
    using PletkaRedka.Data.Common.Models;

    public class Gallery : BaseDeletableModel<int>
    {
        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
