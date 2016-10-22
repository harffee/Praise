using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Praise.Models
{
    public class AccountInfo
    {
        public string Name { get; set; }
        public virtual List<Detail> Details { get; set; }
    }

    public class Detail
    {
        public string Name { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Desc { get; set; }
        public string ToWho { get; set; }
        public virtual AccountInfo AccountInfo { get; set; }
    }

    public class PraiseContext:DbContext
    {
        public DbSet<AccountInfo> AccountInfos { get; set; }
        public DbSet<Detail> Details { get; set; }
    }
}