namespace Ebook1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int ID { get; set; }

        public string BookName { get; set; }

        public string Comment { get; set; }

        public byte[] Image { get; set; }

        public double? Price { get; set; }

        public int LessonID { get; set; }

        public virtual Lesson Lesson { get; set; }
    }
}
