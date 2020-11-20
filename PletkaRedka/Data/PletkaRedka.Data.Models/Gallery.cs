namespace PletkaRedka.Data.Models
{
    using PletkaRedka.Data.Common.Models;

    public class Gallery : BaseDeletableModel<int>
    {
        public string ImageUrl { get; set; }

        public string Discription { get; set; }
    }
}
