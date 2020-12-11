namespace PletkaRedka.Web.ViewModels.Posts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;
    using PletkaRedka.Data.Models;
    using PletkaRedka.Services.Mapping;
    using PletkaRedka.Web.ViewModels.Comments;

    public class PostViewModel : IMapFrom<Post>, IMapTo<Post>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public string UserUserName { get; set; }

        public int VotesCount { get; set; }

        public IEnumerable<CommentCreateInputModel> Comments { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Post, PostViewModel>()
                .ForMember(x => x.VotesCount, options =>
                {
                    options.MapFrom(p => p.Votes.Sum(v => (int)v.Type));
                });
        }
    }
}
