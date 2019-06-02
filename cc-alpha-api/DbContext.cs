using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
namespace cc_alpha_api
{
    public class TestContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(System.Configuration.ConfigurationManager.AppSettings["ConnectionsStrings:DefaultConnection"]);
            base.OnConfiguring(optionsBuilder);
        }
    }

    public class Test
    {
        public int TestID { get; set; }
        public string Text { get; set; }
    }
}