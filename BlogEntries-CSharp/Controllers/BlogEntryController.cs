using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogEntries_CSharp.Controllers
{
    public class BlogEntryController : Controller
    {


        // GET: BlogEntry
        public string Index()
        {
            //return View();
            return "Hello world!";
        }
    }
}