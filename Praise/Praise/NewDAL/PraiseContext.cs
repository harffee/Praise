using Praise.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Praise.DAL
{
    public class PraiseContext:DbContext
    {
        public PraiseContext():base("PraiseContext")
        {

        }
        public DbSet<AccountInfo> Accounts { get; set; }
        public DbSet<Detail> Details { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}