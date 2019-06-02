using Microsoft.EntityFrameworkCore;
using System;
namespace cc_alpha_api
{
    public class TestContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = Environment.GetEnvironmentVariable("SQLCONNSTR_DefaultConnection",EnvironmentVariableTarget.Process);
            // var connString = ConfigurationManager.ConnectionStrings["SQLCONNSTR_DefaultConnection"].ConnectionString;
            optionsBuilder.UseSqlServer(connString);
            base.OnConfiguring(optionsBuilder);
        }
    }

    public class Test
    {
        public int TestID { get; set; }
        public string Text { get; set; }
    }
}