﻿using Ebook1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ebook1.Controllers
{
    public class HomeController : Controller
    {
        EBook1DbEntities2 db = new EBook1DbEntities2();
      
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