using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogEntries_CSharp.Models;

namespace BlogEntries_CSharp.Controllers
{
    public class BlogEntryController : Controller
    {
        BlogsDb blogs = new BlogsDb(); // db or in memory data persistence


        // GET: BlogEntry
        public ActionResult Index()
        {
            List<BlogEntry> blogEnries = blogs.findAllEntries();

            //return View();
            return Content("Hello World!");
        }
    }
}