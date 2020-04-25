using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Ebook1.Models;

namespace Ebook1.Controllers
{
    public class Login1Controller : Controller
    {
        Ebook1Context db = new Ebook1Context();
        // GET: Login1
           [HttpGet]
        public ActionResult LoginG()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginK(User formData)
        {
            User users = new User();
            var Email = db.User.Where(x => x.Email == formData.Email).ToList();
            if (Email.Count != 0)
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
                AddUserRoles(formData.Email);
            }

            return RedirectToRoute("Home");

        }
        public void AddUserRoles(string EmailUser)
        {

            UserAndRole role = new UserAndRole();
            var user = db.User.FirstOrDefault(x => x.Email == EmailUser);
            role.role_id = 2;
            role.user_id = user.ID;
            role.role_name = "User";
            db.UserAndRole.Add(role);
            db.SaveChanges();

        }
        [HttpPost]
 
        public ActionResult LoginG(User user)
        {
            User model = new User();

            model = db.User.FirstOrDefault(x => x.Email == user.Email);
            bool deger = false;
            if (model != null)
            {
                if (model.Password == user.Password)
                {

                    deger = true;



                }

            }

            if (deger == true)
            {
                FormsAuthentication.SetAuthCookie(model.Email, true);
                return RedirectToRoute("Home");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Kullanıcı Bulunamadı . Lütfen Geçerli Bir Kullanıcı Adı ile giriş yapınız.");
                return View();
            }


        }
 
        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("Signin");
        }

    }
}

        
    //public ActionResult Signin(string Mail, string Password)
    //{
    //    var users = db.User.FirstOrDefault(u => u.Mail == Mail);


    //    if (users == null)
    //    {
    //        Anatomy.Models.ViewModels.UserViewModel.FakeHash();
    //    }
    //    if (!ModelState.IsValid)
    //    {
    //        return View();
    //    }

    //    if (users == null || !users.CheckPassword(Password))
    //    {
    //        ModelState.AddModelError(string.Empty, "Kullanıcı Adı veya parola bulunamadı . Tekrar Deneyin.");
    //        return View();
    //    }
    //    else
    //    {

    //        FormsAuthentication.SetAuthCookie(Mail, true);
    //        return RedirectToRoute("Home");
    //    }


    //}

  