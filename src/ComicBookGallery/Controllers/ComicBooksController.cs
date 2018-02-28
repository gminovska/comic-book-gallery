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
            ViewBag.SeriesTitle = "The Amazing Spiderman";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };
            return View();
            //    if(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            //    {
            //        return Redirect("/");
            //        //return new RedirectResult("/");
            //    }

            //    return Content("This is a method in the Controller base class that simplifies our code");
            ////    return new ContentResult() {
            ////        //Pressing Alt + F12 gives us a pek into the class definition 
            ////        Content = "Hello from the comic books controller!"
            ////};

        }
    }
}