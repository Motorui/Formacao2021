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
    public class GrupoController : ControllerBase
    {
        private readonly AppDBContext _db;
        public GrupoController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var grups = await _db.Grupos
                .ToListAsync();
            return Ok(grups);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var gru = await _db.Grupos.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(gru);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Grupo gru)
        {
            _db.Add(gru);
            await _db.SaveChangesAsync();
            return Ok(gru.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Grupo gru)
        {
            _db.Entry(gru).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var gru = new Grupo { ID = id };
            _db.Remove(gru);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
