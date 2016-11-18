using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;


namespace Praise.Models
{
    [Table("Details")]
    public class Detail
    {
        [Key]
        public int DetailID { get; set; }

        [ForeignKey("AccountInfo")]
        public int AccountID { get; set; }

        public string Name { get; set; }

        public DateTime UpdateDate { get; set; }

        public string Desc { get; set; }

        public string ToWho { get; set; }

        public virtual AccountInfo AccountInfo { get; set; }
    }
}