using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Integrated Security=True");
        }
    
        public DbSet<Aula> Aula { get; set; }
    
    }
}
