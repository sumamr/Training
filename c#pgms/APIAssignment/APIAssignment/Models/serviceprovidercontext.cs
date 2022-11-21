using Microsoft.EntityFrameworkCore;

namespace APIAssignment.Models
{
    public class serviceprovidercontext : DbContext
    {
        public serviceprovidercontext(DbContextOptions<userContext> options) : base(options)
        {

        }
        public DbSet<serviceprovider> serviceproviders { get; set; } = null!;
        public DbSet<user> users { get; set; } = null!;
    }
}
