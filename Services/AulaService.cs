using Entities;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class AulaService : DbContext
    {
        public AulaService (DbContextOptions<AulaService> options)
            : base(options)
        {

        }

        public DbSet<Aula> AulaContexts { get; set; }
    }
}
