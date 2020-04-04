using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ebook1.Entity
{
    public class Faculty
    {
        public int ID { get; set; }
        public string FacultyName { get; set; }
    
        public virtual List<Department> Departments { get; set; }

    }
}