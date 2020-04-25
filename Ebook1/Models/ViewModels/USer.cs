using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Ebook1.Models.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string IsManager { get; set; }

        public List<User> Users { get; set; }

        internal static void FakeHash()
        {
            throw new NotImplementedException();
        }
    }
}