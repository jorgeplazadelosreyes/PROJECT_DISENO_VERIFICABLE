using Microsoft.EntityFrameworkCore;
using PROJECT1.Models;

namespace PROJECT1.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {   
        }

        public DbSet<Registration> Registrations { get; set; }
    }
}
