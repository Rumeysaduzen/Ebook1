using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ebook1.Entity
{
    public class Department
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }

        [ForeignKey("DepartmentID")]
        public ICollection<Lesson> Lessons { get; set; }
       
        public virtual Faculty Faculty { get; set; }

    }
}