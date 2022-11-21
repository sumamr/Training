using Microsoft.EntityFrameworkCore;

namespace APIAssignment.Models
{
    public class loginContext:DbContext
    {
        public loginContext(DbContextOptions<loginContext> options) : base(options)
        {

        }
        public DbSet<user> users { get; set; } = null!;
    }
}
