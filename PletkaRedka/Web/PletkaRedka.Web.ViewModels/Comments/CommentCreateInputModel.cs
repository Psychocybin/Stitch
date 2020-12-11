namespace PletkaRedka.Web.ViewModels.Comments
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;

    public class CommentCreateInputModel : IMapFrom<Comment>
    {
        public int PostId { get; set; }

        public string UserId { get; set; }

        public string UserUserName { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
