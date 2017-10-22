using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogEntries_CSharp.Models
{
    public class BlogEntry
    {
        private List<Comment> comments = new List<Comment>();
        private string _title;
        private string user;
        private string _text;
        private DateTime dateTime;
        private List<string> tags = new List<string>();
        private string _slug;


        public string getSlug()
        {
            return _slug;
        }

        public void setSlug(string slug)
        {
            _slug = slug;
        }

        public void setTitle(string title)
        {
            _title = title;
        }

        public void setText(string text)
        {
            _text = text;
        }


        public BlogEntry(string title, string user, string text, string[] tags)
        {
            this._title = title;
            this.user = user;
            this._text = text;
            this.dateTime = DateTime.Today;
            if (tags != null)
            {
                this.tags = tags.ToList();
            }
            this._slug = slugify(title);
        }

        public bool addComment(BlogEntry blogEntry, string user, string text)
        {
            Comment comment = new Comment(blogEntry, user, text);
            try
            {
                comments.Add(comment);
                return true;
            }
            catch (Exception)
            {
                return false;
            }  
        }

        public bool removeComment(Comment comment)
        {
            return comments.Remove(comment);
        }

        public bool addTag(string[] tagsToAdd)
        {
            try
            {
                foreach (string tag in tagsToAdd)
                {
                    tags.Add(tag);
                }
                return true;
            }
            catch (Exception)
            {
                return false;   
            }
        }

        public bool removeTag(string[] tagsToRemove)
        {
            try
            {
                foreach (string tag in tagsToRemove)
                {
                    tags.Remove(tag);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private string slugify(string title)
        {
            return title.Trim().Replace(' ', '-').ToLower();
        }
    }
}