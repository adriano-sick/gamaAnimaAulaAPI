using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class AulaRepository
    {
        private AulaContext _aulaContext;

        public AulaRepository()
        {
            _aulaContext = new AulaContext();
        }

        public List<Aula> GetAulas()
        {
            return _aulaContext.Aula.ToList();
        }

        public Aula GetAulaById(string id)
        {
            return _aulaContext.Aula.FirstOrDefault(a => a.Id == id);
        }

        public Aula GetAulaBySubject (string subject)
        {
            return _aulaContext.Aula.FirstOrDefault(s => s.Subject == subject);
        }

        public async Task<Aula> AddAula(Aula aula)
        {
            try
            {
                var result = await _aulaContext.AddAsync(aula);
                await _aulaContext.SaveChangesAsync();

                return result.Entity;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while saving changes: " + e);
                return null;
            }
        }
    }
}
