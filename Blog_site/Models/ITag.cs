using System.Collections.Generic;

namespace Blog_site.Models
{
    public interface ITag
    {
        string Description { get; set; }
        int Id { get; set; }
        string Name { get; set; }
        IList<Post> Posts { get; set; }
        string UrlSlug { get; set; }
    }
}