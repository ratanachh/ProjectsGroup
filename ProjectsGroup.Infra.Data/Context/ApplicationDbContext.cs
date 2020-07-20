using Microsoft.EntityFrameworkCore;
using ProjectsGroup.Domain.Model;

namespace ProjectsGroup.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
    }
}