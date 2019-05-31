using Microsoft.EntityFrameworkCore;

namespace cc_alpha_api
{
    public class TestContext : DbContext
    {
        public DbSet<Test> Test { get; set; }
    }

    public class Test
    {
        public int TestID { get; set; }
        public string Text { get; set; }
    }
}