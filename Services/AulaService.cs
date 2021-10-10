using Entities;
using Microsoft.EntityFrameworkCore;
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
            catch (Exception e)
            {
                return new();
            }

        }

        public Aula GetAula(string id)
        {
            return _aulaRepository.GetAulaById(id);
        }

        public List<Aula> GetAulaBySubject(string subject)
        {
            return _aulaRepository.GetAulaBySubject(subject);
        }

        public async Task<Aula> AddAula(Aula aula)
        {
            var aulaResult = await _aulaRepository.AddAula(aula);
            return aulaResult;
        }

        public object Entry(Aula aula)
        {
            throw new NotImplementedException();
        }
    }
}
