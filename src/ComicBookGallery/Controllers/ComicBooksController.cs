using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    //Controller classes and the action methods have to be public
    public class ComicBooksController : Controller
    {
        public string Detail()
        {
            return "Hello from the comic books controller!";
        }
    }
}