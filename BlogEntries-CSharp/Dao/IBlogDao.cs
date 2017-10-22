using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogEntries_CSharp.Models;

namespace BlogEntries_CSharp.Dao
{
    public interface IBlogDao
    {
        bool addEntry(BlogEntry blogEntry);
        List<BlogEntry> findAllEntries();
        BlogEntry findEntryBySlug(string slug);
        bool removeBlogEntry(BlogEntry blogEntry);
        bool editBlogEntry(string id, string title, string text);
    }
}
