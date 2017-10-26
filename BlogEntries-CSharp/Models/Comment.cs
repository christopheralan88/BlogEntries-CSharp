using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogEntries_CSharp.Models
{
    public class Comment
    {
        private BlogEntry _blogEntry;
        private string _user;
        private DateTime _dateTime ;
        private string _text;

        public BlogEntry BlogEntry
        {
            get
            {
                return _blogEntry;
            }
            set
            {
                _blogEntry = value;
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
                if (_user != null)
                {
                    _user = value;
                }
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

        public Comment(BlogEntry blogEntry, string user, string text)
        {
            _blogEntry = blogEntry;
            _user = user;
            _dateTime = DateTime.Today;
            _text = text;
        }
    }
}