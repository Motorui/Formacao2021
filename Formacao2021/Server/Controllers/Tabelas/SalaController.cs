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
    public class SalaController : ControllerBase
    {
        private readonly AppDBContext _db;
        public SalaController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var salas = await _db.Salas
                .Include(u=>u.Uh)
                .ToListAsync();
            return Ok(salas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var sala = await _db.Salas.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(sala);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Sala sala)
        {
            _db.Add(sala);
            await _db.SaveChangesAsync();
            return Ok(sala.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Sala sala)
        {
            _db.Entry(sala).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var sala = new Sala { ID = id };
            _db.Remove(sala);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
