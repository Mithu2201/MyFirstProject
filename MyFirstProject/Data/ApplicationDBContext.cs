using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyFirstProject.Models;

namespace MyFirstProject.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}

