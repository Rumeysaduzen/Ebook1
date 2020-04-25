using System.Web.Mvc;

namespace Ebook1.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {

            #region AnatomyLesson
            context.MapRoute(name: "BookList", url: "BookList", defaults: new { controller = "BookEducation", action = "BookList" });
            #endregion
            context.MapRoute(name: "BookAddAdmin", url: "BookAddAdmin", defaults: new { controller = "BookEducation", action = "BookAddAdmin" });
            context.MapRoute(name: "EditBook", url: "EditBook", defaults: new { controller = "BookEducation", action = "EditBook" });



            #region Subject1
            //  context.MapRoute(name: "NewSubject", url: "admin/konu/yeni", defaults: new { controller = "Subject1", action = "NewSubject" });
            context.MapRoute(name: "Subject1", url: "admin/konulistesi", defaults: new { controller = "Subject1", action = "Subject1" });
            context.MapRoute(name: "EditSubject", url: "admin/konu/duzenle", defaults: new { controller = "Subject1", action = "EditSubject" });
            context.MapRoute(name: "DeleteSubject", url: "admin/konu/sil", defaults: new { controller = "Subject1", action = "DeleteSubject" });
            #endregion

            #region Subject1
            context.MapRoute(name: "Question1", url: "admin/soru", defaults: new { controller = "Question1", action = "Question1" });
            //context.MapRoute(name: "NewQuestion", url: "admin/yenisoru", defaults: new { controller = "Question1", action = "NewQuestion" });

            #endregion


            #region Subject1
            context.MapRoute(name: "UserList", url: "admin/kullanıcı", defaults: new { controller = "User", action = "UserList" });
            context.MapRoute(name: "NewUser", url: "admin/kullanıcı/yeni", defaults: new { controller = "User", action = "NewUser" });

            #endregion

            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new { controller = "Sayfa", action = "Anasayfa", id = UrlParameter.Optional }
            );
            context.MapRoute("admin", "admin", new { controller = "Sayfa", action = "Anasayfa" });
            context.MapRoute("Register", "Register", new { controller = "User1", action = "NewUser" });
            context.MapRoute("NewQuestion", "NewQuestion", new { controller = "Question1", action = "NewQuestion" });
            context.MapRoute("NewSubject", "NewSubject", new { controller = "Subject1", action = "NewSubject" });
            context.MapRoute("UpdateQuestion", "UpdateQuestion", new { controller = "Question1", action = "UpdateQuestion" });
            //context.MapRoute("DeleteSubject", "DeleteSubject",  new { controller = "Subject1", action = "Delete" });


        }
    }
}