
namespace project_tests.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        DbSet<User> Users => Set<User>();
    }
}