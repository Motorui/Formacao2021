using Formacao2021.Server.Data;
using Formacao2021.Shared.Models.Marcacoes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Formacao2021.Server.Controllers.Marcacao
{
    [Route("api/[controller]")]
    [ApiController]
    public class InscricaoController : ControllerBase
    {
        private readonly AppDBContext _db;
        public InscricaoController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var ins = await _db.Inscricoes
                .ToListAsync();
            return Ok(ins);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid MId)
        {
            var mar = await _db.Inscricoes
                .FirstOrDefaultAsync(a => a.MarcacaoID == MId);
            return Ok(mar);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Inscricao ins)
        {
            _db.Add(ins);
            await _db.SaveChangesAsync();
            return Ok(ins);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Inscricao ins)
        {
            _db.Entry(ins).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid MId, Guid FId)
        {
            var ins = new Inscricao { MarcacaoID = MId, FormandoID  = FId };
            _db.Remove(ins);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
