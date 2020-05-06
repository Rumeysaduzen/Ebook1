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
        EBook1DbEntities2 db = new EBook1DbEntities2(); 
        // GET: Product
        public ActionResult Product()
        {
            var product = db.Book.ToList();
            return View(product);
        }
    }
}