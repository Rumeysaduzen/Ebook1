namespace Ebook1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserAndRole")]
    public partial class UserAndRole
    {
        [StringLength(10)]
        public string ID { get; set; }

        public int role_id { get; set; }

        public int user_id { get; set; }

        [StringLength(10)]
        public string role_name { get; set; }
    }
}
