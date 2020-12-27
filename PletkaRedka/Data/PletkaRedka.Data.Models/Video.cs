namespace PletkaRedka.Data.Models
{
    using PletkaRedka.Data.Common.Models;

    public class Video : BaseDeletableModel<int>
    {
        public string Title { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string VideoUrl { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
