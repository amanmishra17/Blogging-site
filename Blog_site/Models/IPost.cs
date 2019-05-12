using System.Collections.Generic;
using System.Data;

namespace Blog_site.Models
{
    public interface IPost
    {
        Category Category { get; set; }
        string Description { get; set; }
        int Id { get; set; }
        DataSetDateTime? Modified { get; set; }
        DataSetDateTime PostedOn { get; set; }
        bool Published { get; set; }
        string ShortDescription { get; set; }
        IList<Tag> Tags { get; set; }
        string Title { get; set; }
        string UrlSlug { get; set; }
    }
}