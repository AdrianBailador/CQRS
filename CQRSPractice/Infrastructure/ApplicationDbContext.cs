using CQRSPractice.Domain;
using Microsoft.EntityFrameworkCore;

namespace CQRSPractice.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TaskItem> TaskItem { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

    }

}


