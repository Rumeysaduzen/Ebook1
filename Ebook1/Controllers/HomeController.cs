using Ebook1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ebook1.Controllers
{
    public class HomeController : Controller
    {
        Ebook1Context db = new Ebook1Context();
        // GET: Home
        public ActionResult Index()
        {
            {
                var product = db.Lesson.ToList();
                return View(product);
            }
        }

    }
}