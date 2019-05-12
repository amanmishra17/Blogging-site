using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Blog_site.Models
{
    public class Post : IPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string UrlSlug { get; set; }
        public bool Published { get; set; }
        public DataSetDateTime PostedOn { get; set; }
        public DataSetDateTime? Modified { get; set; }
        public Category Category { get; set; }
        public IList<Tag> Tags { get; set; }

    }
}