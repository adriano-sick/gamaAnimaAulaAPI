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
            optionsBuilder.UseSqlServer(@"Server=aulatest.mssql.somee.com; Database=aulatest; User Id=sickadri_SQLLogin_1; Password=8d97g9gkmt;");
        }
    
        public DbSet<Aula> Aula { get; set; }
    
    }
}
