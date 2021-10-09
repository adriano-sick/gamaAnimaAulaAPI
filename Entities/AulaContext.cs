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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=aulasDb;Trusted_Connection=True;");
            Console.WriteLine("tentou conectar");
        }
    
        public DbSet<Aula> Aula { get; set; }
    
    }
}
