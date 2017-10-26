using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace BlogEntries_CSharp.Models
{
    public class BlogEntry
    {
        private List<Comment> _comments = new List<Comment>();
        private string _title;
        private string _user;
        private string _text;
        private DateTime _dateTime;
        private List<string> tags = new List<string>();
        private string _slug;


        public string Slug
        {
            get
            {
                return _slug;
            }
            set
            {
                _slug = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }

        public string User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }

        public DateTime DateTime
        {
            get
            {
                return _dateTime;
            }
            set
            {
                _dateTime = value;
            }
        }

        public List<Comment> Comments
        {
            get
            {
                return _comments;
            }
            set
            {
                _comments = value;
            }
        }

        // Default constructor
        public BlogEntry() { }

        public BlogEntry(string title, string user, string text, string[] tags)
        {
            _title = title;
            _user = user;
            _text = text;
            _dateTime = DateTime.Today;
            if (tags != null)
            {
                this.tags = tags.ToList();
            }
            _slug = Slugify(title);
        }

        public bool AddComment(BlogEntry blogEntry, string user, string text)
        {
            Comment comment = new Comment(blogEntry, user, text);
            try
            {
                _comments.Add(comment);
                return true;
            }
            catch (Exception)
            {
                return false;
            }  
        }

        public bool RemoveComment(Comment comment)
        {
            return _comments.Remove(comment);
        }

        public bool AddTag(string[] tagsToAdd)
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

        public bool RemoveTag(string[] tagsToRemove)
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

        private string Slugify(string title)
        {
            return Regex.Replace(title, @"\s+", "-").ToLower();
        }
    }
}