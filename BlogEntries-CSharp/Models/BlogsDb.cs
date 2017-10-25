using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogEntries_CSharp.Dao;

namespace BlogEntries_CSharp.Models
{
    public class BlogsDb : IBlogDao
    {
        private List<BlogEntry> blogEntries = new List<BlogEntry>();
        private readonly string EXCEPTION_MESSAGE = "A blog entry with that title already exists.  Please change the title and try saving again.";


        public BlogsDb()
        {
            BlogEntry blogEntry = new BlogEntry("Why I love C#", "admin", "Because it's awesome.", new string[] { "C#" });
            BlogEntry blogEntry2 = new BlogEntry("Why I love ASP.NET MVC", "admin", "Becaues it's great.", new string[] { "C#", "ASP.NET", "MVC" });
            BlogEntry blogEntry3 = new BlogEntry("Why I love .NET", "admin", "Because it's a more centralized framework than the Java community offers.", new string[] { ".NET", "EF" });
            blogEntries.Add(blogEntry);
            blogEntries.Add(blogEntry2);
            blogEntries.Add(blogEntry3);
        }

        public bool AddEntry(BlogEntry blogEntry)
        {
            BlogEntry alreadyExistsBlogEntry = blogEntries.Find(b => b.Slug.Equals(blogEntry.Slug));
            if (alreadyExistsBlogEntry != null)
            {
                throw new BlogAlreadyExistsException(EXCEPTION_MESSAGE);
            }

            blogEntries.Add(blogEntry);
            if (blogEntries.Contains(blogEntry))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public bool EditBlogEntry(BlogEntry entry)
        {
            BlogEntry blogentry = blogEntries.Find(b => b.Slug.Equals(entry.Slug));
            
            if (blogentry == null)
            {
                throw new Exception("Could not find blog entry");
            } 
            else
            {
                int entryIndex = blogEntries.FindIndex(b => b.Slug.Equals(entry.Slug));
                blogEntries[entryIndex] = entry;
                return true;
            }
        }

        public List<BlogEntry> FindAllEntries()
        {
            return blogEntries;
        }

        public BlogEntry FindEntryBySlug(string slug)
        {
            return blogEntries.Find(b => b.Slug.Equals(slug));
        }

        public bool RemoveBlogEntry(BlogEntry blogEntry)
        {
            return blogEntries.Remove(blogEntry);
        }

    }
}