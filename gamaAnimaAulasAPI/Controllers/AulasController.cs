using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities;
using Services;

namespace gamaAnimaAulasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulasController : ControllerBase
    {
        private AulaService _aulaService;

        public AulasController()
        {
            _aulaService = new AulaService();
        }

        // GET: api/Aulas
        [HttpGet]
        public List<Aula> GetAulaContexts()
        {
            var aulasList = _aulaService.GetAula();

            return aulasList;
        }

        // GET: api/Aulas/5
        [HttpGet("{id}")]
        public Aula GetAula(int id)
        {
            return _aulaService.GetAula(id);
        }

        // GET: api/Aulas/subject
        [HttpGet("subject/{subject}")]
        public List<Aula> GetAulaBySubject(string subject)
        {
            return _aulaService.GetAulaBySubject(subject);
        }

        // GET: api/Aulas/teacher
        [HttpGet("teacher/{teacher}")]
        public List<Aula> GetAulaByTeacher(string teacher)
        {
            return _aulaService.GetAulaByTeacher(teacher);
        }

        // PUT: api/Aulas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAula(string id, Aula aula)
        {
            if (id != aula.Id.ToString())
            {
                return BadRequest();
            }
            else
            {
                await _aulaService.PutAula(aula);
                return Ok();
            }
        }

        // POST: api/Aulas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Aula>> PostAula(Aula aula)
        {
            if(!AulaExists(aula.Id))
            {
                return await _aulaService.AddAula(aula);
            }
            else
            {
                return null;
            }
        }

        // DELETE: api/Aulas/5  TESTE
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAula(int id)
        {
            if (AulaExists(id))
            {
                _aulaService.DeleteAula(id);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        private bool AulaExists(int id)
        {
            return _aulaService.GetAula().Any(e => e.Id == id);
        }
    }
}
