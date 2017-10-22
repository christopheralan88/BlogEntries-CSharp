using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogEntries_CSharp.Models
{
    public class BlogAlreadyExistsException : Exception
    {
        public BlogAlreadyExistsException(string message) : base(message)
        {

        }
    }
}