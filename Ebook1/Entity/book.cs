using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ebook1.Entity
{
    public class Book
    {
        public int ID { get; set; }
        public string BookName { get; set; }

        public string Comment { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }


        public int LessonID { get; set; }
        public virtual Lesson Lesson { get; set; }
   

    }
}