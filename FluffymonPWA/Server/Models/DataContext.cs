using Microsoft.EntityFrameworkCore;

namespace FluffymonPWA.Server.Models
{
    public class DataContext
    {
        /*public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }*/

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
