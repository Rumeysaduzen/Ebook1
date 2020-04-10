using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ebook1.Entity
{
    public class Lesson
    {
        public int ID { get; set; }
        public string LessonName { get; set; }

        
        public virtual  List<Book> Books { get; set; }
        public int DepartmanID { get; set; }

        public virtual Department Department { get; set; }



    }
}