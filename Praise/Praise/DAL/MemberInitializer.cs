using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Praise.Models;


namespace Praise.DAL
{
    public class MemberInitializer:System.Data.Entity.
        DropCreateDatabaseIfModelChanges<PraiseContext>
    {
        protected override void Seed(PraiseContext context)
        {
            var accounts = new List<AccountInfo>
            {
                new AccountInfo {Name="Jing Zhang" },
                new AccountInfo {Name="Meng Liang" },
                new AccountInfo {Name="Alan Wang" },
                new AccountInfo {Name="Abby Qu" },
                new AccountInfo {Name="Anna Guo" },
                new AccountInfo {Name="Ben Dong" },
                new AccountInfo {Name="Fred Gao" },
                new AccountInfo {Name="Hebe Shi" },
                new AccountInfo {Name="Jack Zhou" },
                new AccountInfo {Name="Ketty Yu" },
                new AccountInfo {Name="Laney Li" }
            };
            accounts.ForEach(s => context.Accounts.Add(s));
            context.SaveChanges();
        }
    }
}