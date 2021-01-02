using AlumniAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AlumniAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> applicationUsers{get; set;}
    }
}