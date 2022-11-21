using Microsoft.EntityFrameworkCore;

namespace APIAssignment.Models
{
    public class userContext :DbContext
    {
        public userContext(DbContextOptions<userContext> options) : base(options)
        {

        }
         public DbSet<user> users { get; set; } = null!;
        public DbSet<serviceprovider> serviceproviders { get; set; } = null!;
    }
}
