using Formacao2021.Server.Data;
using Formacao2021.Shared.Models.Tabelas;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Formacao2021.Server.Controllers.Tabelas
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly AppDBContext _db;
        public CursoController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var curs = await _db.Cursos.ToListAsync();
            return Ok(curs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var cur = await _db.Cursos.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(cur);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Curso cur)
        {
            _db.Add(cur);
            await _db.SaveChangesAsync();
            return Ok(cur.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Curso cur)
        {
            _db.Entry(cur).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var cur = new Curso { ID = id };
            _db.Remove(cur);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
