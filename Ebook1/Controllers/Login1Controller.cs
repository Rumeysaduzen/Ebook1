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
        EBook1DbEntities2 db = new EBook1DbEntities2();
        // GET: Login1
        [HttpGet]
        
        public ActionResult LoginG()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LoginK()
        {


            return View();

        }

        [HttpPost]
        public ActionResult LoginK(User formData)
        {
            User users = new User();
            var Email = db.User.Where(x => x.Email == formData.Email).ToList();
        
      
                
                users.Name = formData.Name;
                users.Surname = formData.Surname;
                users.Password = formData.Password;
                users.Email = formData.Email;
                users.IsManager = false;
                users.IsDeleted = false;
                users.DepartmentID = 1;
                db.User.Add(users);
               
               db.SaveChanges();
            

            return RedirectToRoute("LoginG");

        }
        public void AddUserRoles(string EmailUser)
        {

            UserAndRole role = new UserAndRole();
            var user = db.User.FirstOrDefault(x => x.Email == EmailUser);
            role.Role_id = 1;
            role.User_id = user.ID;
            role.Role_name = "Admin";
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
            return RedirectToRoute("LoginG");
        }

    }
}
