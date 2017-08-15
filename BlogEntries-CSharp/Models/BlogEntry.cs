using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogEntries_CSharp.Models
{
    public class BlogEntry
    {
        private List<Comment> comments = new List<Comment>();
        private string title;
        private string user;
        private string text;
        private DateTime dateTime;
        private List<string> tags = new List<string>();
        private string slug;


        public BlogEntry(string title, string user, string text, string[] tags)
        {
            this.title = title;
            this.user = user;
            this.text = text;
            this.dateTime = DateTime.Today;
            if (tags != null)
            {
                this.tags = tags.ToList();
            }
            this.slug = slugify(title);
        }

        private string slugify(string title)
        {
            return title.Replace(' ', '-').ToLower();
        }
    }
}