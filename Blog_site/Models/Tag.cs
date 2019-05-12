using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Blog_site.Models
{
    public class Tag : ITag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public string Description { get; set; }
        public IList<Post> Posts { get; set; }

    }
}