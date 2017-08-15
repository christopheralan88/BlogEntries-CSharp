using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogEntries_CSharp.Models
{
    public class Comment
    {
        private BlogEntry blogEntry;
        private string user;
        private DateTime dateTime ;
        private string text;


        public Comment(BlogEntry blogEntry, string user, string text)
        {
            this.blogEntry = blogEntry;
            this.user = user;
            this.dateTime = DateTime.Today;
            this.text = text;
        }
    }
}