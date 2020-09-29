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
    public class EmpresaController : ControllerBase
    {
        private readonly AppDBContext _db;
        public EmpresaController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var emps = await _db.Empresas
                .Include(g => g.Grupo)
                .ToListAsync();
            return Ok(emps);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var emp = await _db.Empresas.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(emp);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Empresa emp)
        {
            _db.Add(emp);
            await _db.SaveChangesAsync();
            return Ok(emp.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Empresa emp)
        {
            _db.Entry(emp).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var emp = new Empresa { ID = id };
            _db.Remove(emp);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
