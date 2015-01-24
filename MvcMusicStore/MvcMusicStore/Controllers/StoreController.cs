using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public string Index()
        {
            return "Hello from Store.Index()";
        }

        //
        // GET: /Browse?genre=?Disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre=" + genre);

            return message;
        }

        //
        // GET: /Details/5
        public string Details(int id, string genre)
        {
            string message = "Store.Details, ID=" + id + ", Genre=" + genre;

            return message;
        }

        //public ActionResult Sample()
        //{
        //    var albums = new List<Album>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        albums.Add(new Album {Title = "Product " + i});
        //    }
        //    ViewBag.Albums = albums;
        //    return View("Sample");
        //}
    }
}