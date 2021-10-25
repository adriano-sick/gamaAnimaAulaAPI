using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class AulaRepository
    {
        private readonly AulaContext _aulaContext;

        public AulaRepository()
        {
            _aulaContext = new AulaContext();
        }

        public List<Aula> GetAulas()
        {
            return _aulaContext.Aula.ToList();
        }

        public Aula GetAulaById(int id)
        {
            return _aulaContext.Aula.FirstOrDefault(a => a.Id == id);
        }

        public List<Aula> GetAulaBySubject(string subject)
        {
            return _aulaContext.Aula.Where(aula => aula.Subject == subject).ToList();
        }

        public List<Aula> GetAulaByTeacher(string teacher)
        {
            return _aulaContext.Aula.Where(aula => aula.Teacher == teacher).ToList();
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

        public Aula DeleteAula(int id)
        {
            var aulaDel = _aulaContext.Aula.FirstOrDefault(a => a.Id == id);
            _aulaContext.Remove(aulaDel);
            _aulaContext.SaveChangesAsync();
            return aulaDel;
        }

        public async Task<Aula> PutAula(Aula aula)
        {
            try
            {
                var result = _aulaContext.Update(aula);
                await _aulaContext.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error while updating changes: " + e);
                return null;
            }
        }
    }
}
