using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogEntries_CSharp.Controllers
{
    public class BlogEntryController : Controller
    {
        //Blogs blogs = new Blogs(); // db or in memory data persistence

        // GET: BlogEntry
        public ActionResult Index()
        {
            //return View();
            return Content("Hello World!");
        }
    }
}