using Microsoft.EntityFrameworkCore;

namespace cc_alpha_api
{
    public class TestContext : DbContext
    {
        public DbSet<Test> Test { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "APPSETTING_ConnectionsStrings:DefaultConnection"
            );
        }
    }

    public class Test
    {
        public int TestID { get; set; }
        public string Text { get; set; }
    }
}