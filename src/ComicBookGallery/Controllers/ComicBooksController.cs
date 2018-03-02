using ComicBookGallery.Models;
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
        //The action methods return Action Result types (base class ActionResult), such as ContentResult or RedirectResult
        public ActionResult Detail()
        {
            
            return View();
        }
    }
}