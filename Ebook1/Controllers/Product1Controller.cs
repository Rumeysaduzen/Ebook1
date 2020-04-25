using Ebook1.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ebook1.Controllers
{

    public class Product1Controller : Controller
    {
        Ebook1Context db = new Ebook1Context(); 
        // GET: Product
        public ActionResult Product()
        {
            var product = db.Book.ToList();
            return View(product);
        }
    }
}