using System;
using System.Collections.Generic;


namespace Praise.Models
{
    public class Detail
    {
        public string Name { get; set; }
        DateTime Date { get; set; }
        string Desc { get; set; }
        string ToWho { get; set; }

        public virtual ICollection<AccountInfo> AccountInfos { get; set; }

    }
}