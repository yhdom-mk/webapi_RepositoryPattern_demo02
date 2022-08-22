using Microsoft.EntityFrameworkCore;
using webapi_RepositoryPattern_demo02.Models;

namespace webapi_RepositoryPattern_demo02
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Album> albums { get; set; }
        public DbSet<Tune> tune { get; set; }
    }
}
