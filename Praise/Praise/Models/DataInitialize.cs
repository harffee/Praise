using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Praise.Models;

namespace Praise.Models
{
    public class DataInitialize : System.Data.Entity.DropCreateDatabaseIfModelChanges<PraiseContext>

    {
        protected override void Seed(PraiseContext context)
        {
            var accounts = new List<AccountInfo>
            {
            new AccountInfo{Name="Jing Zhang"},
            new AccountInfo{Name="Meng Liang"},
            new AccountInfo{Name="Ketty Yu"}
            };

            accounts.ForEach(s => context.AccountInfos.Add(s));
            context.SaveChanges();

            var details = new List<Detail>
            {
            new Detail{Name="Jing Zhang",UpdateDate=DateTime.Parse("2016-10-20 20:00:00"),Desc="Good Lady",ToWho="Ketty Yu"},
            new Detail{Name="Meng Liang",UpdateDate=DateTime.Parse("2016-10-18 18:00:00"),Desc="Luck Luck",ToWho="Jing Zhang"}
                        };

            details.ForEach(s => context.Details.Add(s));
            context.SaveChanges();
        }

        
    }
}