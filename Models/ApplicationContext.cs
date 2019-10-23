using Microsoft.EntityFrameworkCore;
using ApiWithAjax.Models;
using ApiWithAjax.Data.Mapping;

namespace ApiWithAjax.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {    
            new UserMap(modelBuilder.Entity<User>());
           
            base.OnModelCreating(modelBuilder);
        }
 

        public DbSet<ApiWithAjax.Models.User> User { get; set; }
    }
}


