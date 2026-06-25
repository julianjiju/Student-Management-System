using Microsoft.EntityFrameworkCore;

namespace cruddemo.Data
{
    public class ApplicationDbContext: DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Student> students { get; set; }
    }
} 
