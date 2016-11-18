using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Praise.Models
{
    [Table("Accounts")]
    public class AccountInfo
    {
        [Key]
        public int AccountID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Detail> Details { get; set; }
    }

}