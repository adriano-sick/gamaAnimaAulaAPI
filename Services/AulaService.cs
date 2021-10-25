using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class AulaService
    {
        private AulaRepository _aulaRepository;

        public AulaService()
        {
            _aulaRepository = new();
        }
        public List<Aula> GetAula()
        {
            try
            {
                var lista = _aulaRepository.GetAulas();
                return lista;

            }
            catch (Exception)
            {
                return new();
            }

        }

        public Aula GetAula(int id)
        {
            return _aulaRepository.GetAulaById(id);
        }

        public List<Aula> GetAulaBySubject(string subject)
        {
            return _aulaRepository.GetAulaBySubject(subject);
        }

        public List<Aula> GetAulaByTeacher(string teacher)
        {
            return _aulaRepository.GetAulaByTeacher(teacher);
        }

        public async Task<Aula> AddAula(Aula aula)
        {
            return await _aulaRepository.AddAula(aula);
        }

        public Aula DeleteAula(int id)
        {
            return _aulaRepository.DeleteAula(id);
        }

        public async Task<Aula> PutAula(Aula aula)
        {
            return await _aulaRepository.PutAula(aula);
        }

        public object Entry(Aula aula)
        {
            throw new NotImplementedException();
        }
    }
}
