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
        private string exceptionMessage = "A blog entry with that title already exists.  Please change the title and try saving again.";


        public BlogsDb()
        {
            BlogEntry blogEntry = new BlogEntry("Why I love Java", "admin", "Because it's awesome.", new string[] { "Java" });
            BlogEntry blogEntry2 = new BlogEntry("Why I love Spark", "admin", "Becaues it's great.", new string[] { "Java", "Spark" });
            BlogEntry blogEntry3 = new BlogEntry("Why I love Spring", "admin", "Because everybody says I should like it.", new string[] { "Spring", "Java" });
            blogEntries.Add(blogEntry);
            blogEntries.Add(blogEntry2);
            blogEntries.Add(blogEntry3);
        }

        public bool addEntry(BlogEntry blogEntry)
        {
            BlogEntry alreadyExistsBlogEntry = blogEntries.Find(b => b.getSlug().Equals(blogEntry.getSlug()));
            if (alreadyExistsBlogEntry != null)
            {
                throw new BlogAlreadyExistsException(exceptionMessage);
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

        public bool editBlogEntry(string slug, string title, string text)
        {
            BlogEntry blogentry = blogEntries.Find(b => b.getSlug().Equals(slug));

            if (blogentry == null)
            {
                throw new BlogAlreadyExistsException(exceptionMessage);
            } 
            else
            {
                blogentry.setSlug(slug);
                blogentry.setTitle(title);
                blogentry.setText(text);
                return true;
            }
        }

        public List<BlogEntry> findAllEntries()
        {
            return blogEntries;
        }

        public BlogEntry findEntryBySlug(string slug)
        {
            return blogEntries.Find(b => b.getSlug().Equals(slug));
        }

        public bool removeBlogEntry(BlogEntry blogEntry)
        {
            return blogEntries.Remove(blogEntry);
        }

    }
}