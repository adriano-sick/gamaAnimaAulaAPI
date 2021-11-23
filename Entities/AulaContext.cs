using Microsoft.EntityFrameworkCore;
using System;

namespace Entities
{
    public class AulaContext : DbContext
    {

        public AulaContext(DbContextOptions<AulaContext> contextOptions) : base(contextOptions)
        {
        }

        public AulaContext()
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
        }    
        public DbSet<Aula> Aula { get; set; }    
    }
}
