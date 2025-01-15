using Microsoft.EntityFrameworkCore;
using UserApi.Model;

namespace UserApi.DataBaseContext
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Emails> Emails { get; set; }
    }
}
