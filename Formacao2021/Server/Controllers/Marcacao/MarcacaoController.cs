﻿using Formacao2021.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Formacao2021.Server.Controllers.Marcacao
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcacaoController : ControllerBase
    {
        private readonly AppDBContext _db;
        public MarcacaoController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var marcs = await _db.Marcacoes
                .Include(s => s.Sala)
                .Include(u => u.Uh)
                .Include(c => c.Curso)
                .ToListAsync();
            return Ok(marcs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var mar = await _db.Marcacoes.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(mar);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Shared.Models.Marcacoes.Marcacao mar)
        {
            _db.Add(mar);
            await _db.SaveChangesAsync();
            return Ok(mar.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Shared.Models.Marcacoes.Marcacao mar)
        {
            _db.Entry(mar).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var mar = new Shared.Models.Marcacoes.Marcacao { ID = id };
            _db.Remove(mar);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
