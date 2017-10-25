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
        bool AddEntry(BlogEntry blogEntry);
        List<BlogEntry> FindAllEntries();
        BlogEntry FindEntryBySlug(string slug);
        bool RemoveBlogEntry(BlogEntry blogEntry);
        bool EditBlogEntry(BlogEntry entry);
    }
}
