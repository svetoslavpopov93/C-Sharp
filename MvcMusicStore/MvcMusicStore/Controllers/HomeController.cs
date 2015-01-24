using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "I love cake!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Sample()
        {
            ViewBag.Message = "Hi! This is the \"Store.html\" page!";
            var albums = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                albums.Add("asdad" + i);
            }
            ViewBag.Albums = albums;

            return View("Sample");
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}
