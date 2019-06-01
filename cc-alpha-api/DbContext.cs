using Microsoft.EntityFrameworkCore;

namespace cc_alpha_api
{
    public class TestContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=tcp:alpha-cc.database.windows.net,1433;Initial Catalog=alpha-cc-db;Persist Security Info=False;User ID=alpha-cc-admin;Password=azCCpw1!;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
            );
            base.OnConfiguring(optionsBuilder);
        }
    }

    public class Test
    {
        public int TestID { get; set; }
        public string Text { get; set; }
    }
}