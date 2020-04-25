using Ebook1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;

using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


using System.Configuration;
using System.Data;


namespace Ebook1.Areas.admin.Controllers
{
    public class BookEducationController : Controller
    {
        // GET: admin/BookEducation
        public ActionResult BookList()
        {
            using (Ebook1Context db = new Ebook1Context() )
            {

                return View(db.Book.ToList());
            }
        }
        [HttpGet]
        public ActionResult BookAddAdmin()
        {
            using (Ebook1Context db = new Ebook1Context())
            {
                ViewBag.Book = db.Lesson.ToList();
          
                return View();
            }
         
        }

        [HttpPost]
        public ActionResult BookAddAdmin(string BookName, string Comment, double Price, HttpPostedFileBase ImageData)
        {
            Ebook1Context db = new Ebook1Context();
            Book book = new Book();
        
            byte[] bytes;
            if (ImageData != null)
            {
                using (BinaryReader br = new BinaryReader(ImageData.InputStream))
                {
                    bytes = br.ReadBytes(ImageData.ContentLength);
                }
                book.Image = bytes;
            }
            else
            {
                book.Image = null;
            }
            book.BookName = BookName;
            book.Price = Price;
            book.Comment = Comment;
    

    
            db.Book.Add(book);
            db.SaveChanges();

           

           
            return RedirectToRoute("Question1");
        }

        public ActionResult EditBook(int ID)
        {
            using (Ebook1Context db = new Ebook1Context())
            {

                ViewBag.Book = db.Lesson.ToList();
                Book book = db.Book.SingleOrDefault(x => x.ID.Equals(ID));
                if (book != null)
                {
                    return View(book);
                }
            }
            return RedirectToRoute("BookList");
        }


        [HttpPost]
        public ActionResult EditBook(Book model)
        {
            if (ModelState.IsValid)
            {
                using (Ebook1Context db = new Ebook1Context())
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    ModelState.Clear();

                }
            }
            return View(model);
        }


        public ActionResult DeleteSubject(int ID)
        {
            string message = string.Empty;
            using (Ebook1Context db = new Ebook1Context())
            {
                Book book = db.Book.SingleOrDefault(x => x.ID.Equals(ID));
                if (book != null)
                {
                    db.Book.Remove(book);
                    db.SaveChanges();
                    message = JsonConvert.SerializeObject(new { durum = "OK", mesaj = "Konu Silindi" });
                }
                else
                {
                    message = JsonConvert.SerializeObject(new { durum = "No", mesaj = "Konu Silinemedi" });
                }
            }
            return RedirectToRoute("BookList");
        }
    }

}
