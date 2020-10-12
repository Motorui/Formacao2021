using Formacao2021.Server.Data;
using Formacao2021.Shared.Models.Tabelas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Formacao2021.Server.Controllers.Tabelas
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormandoController : ControllerBase
    {
        private readonly AppDBContext _db;
        public FormandoController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var curs = await _db.Formandos
                .Include(u => u.Uh)
                .Include(d => d.Departamento)
                .OrderBy(n=>n.Nome)
                .ToListAsync();
            return Ok(curs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var formando = await _db.Formandos.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(formando);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Formando formando)
        {
            _db.Add(formando);
            await _db.SaveChangesAsync();
            return Ok(formando.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Formando formando)
        {
            _db.Entry(formando).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var formando = new Formando { ID = id };
            _db.Remove(formando);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
