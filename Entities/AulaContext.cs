using Microsoft.EntityFrameworkCore;

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

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=aulatest.mssql.somee.com; Database=aulatest; User Id=sickadri_SQLLogin_1; Password=8d97g9gkmt;");
        //}
        
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //nao esta subindo as modificacoes daqui no git `-` testar - conteudo original, no txt aulas no desktop
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("AULACONNECTION"));
        }
    
        public DbSet<Aula> Aula { get; set; }
    
    }
}
