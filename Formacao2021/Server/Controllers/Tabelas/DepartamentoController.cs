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
    public class DepartamentoController : ControllerBase
    {
        private readonly AppDBContext _db;
        public DepartamentoController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var deps = await _db.Departamentos.ToListAsync();
            return Ok(deps);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var dep = await _db.Departamentos.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(dep);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Departamento dep)
        {
            _db.Add(dep);
            await _db.SaveChangesAsync();
            return Ok(dep.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Departamento dep)
        {
            _db.Entry(dep).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var dep = new Departamento { ID = id };
            _db.Remove(dep);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
