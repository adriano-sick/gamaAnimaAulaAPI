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
        public Aula GetAula(string id)
        {
            return _aulaService.GetAula(id);
        }

        // PUT: api/Aulas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAula(string id, Aula aula)
        //{
        //    if (id != aula.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _aulaService.Entry(aula).State = EntityState.Modified;

        //    try
        //    {
        //        await _aulaService.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AulaExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Aulas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Aula>> PostAula(Aula aula)
        {
            return await _aulaService.AddAula(aula);
        }

        // DELETE: api/Aulas/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAula(string id)
        //{
        //    var aula = await _aulaService.AulaContexts.FindAsync(id);
        //    if (aula == null)
        //    {
        //        return NotFound();
        //    }

        //    _aulaService.AulaContexts.Remove(aula);
        //    await _aulaService.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool AulaExists(string id)
        //{
        //    return _aulaService.AulaContexts.Any(e => e.Id == id);
        //}
    }
}
