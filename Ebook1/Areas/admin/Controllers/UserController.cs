using Ebook1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ebook1.Areas.admin.Controllers
{
    public class UserController : Controller
    {

        EBook1DbEntities2 db = new EBook1DbEntities2();
        // GET: admin/User
        public ActionResult UserList()
        {
            EBook1DbEntities2 user = new EBook1DbEntities2();
            return View(user.User.ToList());


        }
        [HttpGet]
        public ActionResult NewUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewUser(User formData)
        {
            User users = new User();
            var mail = db.User.Where(x => x.Email == formData.Email).ToList();
            if (mail.Count != 0)
            {
                ModelState.AddModelError(string.Empty, "Bu Email Adresi zaten kayıtlı. Baska bir mail adresi deneyiniz.");
                return View();
            }
            else
            {
                users.Name = formData.Name;
                users.Surname = formData.Surname;
                users.Password = formData.Password;
                users.Email = formData.Email;
                users.IsManager = false;
                users.IsDeleted = false;
                db.User.Add(users);
                db.SaveChanges();
                AddRoles(formData.Email);
            }

            return RedirectToRoute("Anasayfa");

        }

        public void AddRoles(string MailUser)
        {

            UserAndRole role = new UserAndRole();
            var user = db.User.FirstOrDefault(x => x.Email == MailUser);
            role.Role_id = 1;
            role.User_id = user.ID;
            role.Role_name = "Admin";
            db.UserAndRole.Add(role);
            db.SaveChanges();

        }
        [HttpGet]
        public ActionResult EditUser(int ID)
        {
            var model = db.User.Find(ID);
            if (model == null)
                return HttpNotFound();
            Session.Add("Id", ID);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditUser(bool IsManager)
        {
            int id = Convert.ToInt32(Session["Id"]);

            var user = db.User.FirstOrDefault(x => x.ID == id);
            user.IsManager = IsManager;
            db.SaveChanges();
            return RedirectToRoute("UserList");

        }
        public ActionResult DeleteUser(User user)
        {

            var model = db.User.Find(user.ID);


            if (model == null)
            {
                return HttpNotFound();

            }

            db.User.Remove(model);

            db.SaveChanges();

            return RedirectToAction("UserList");
        }

    }
}
