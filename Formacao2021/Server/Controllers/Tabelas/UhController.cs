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
    public class UhController : ControllerBase
    {
        private readonly AppDBContext _db;
        public UhController(AppDBContext context)
        {
            this._db = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var uhs = await _db.Uhs.ToListAsync();
            return Ok(uhs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var uh = await _db.Uhs.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(uh);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Uh uh)
        {
            _db.Add(uh);
            await _db.SaveChangesAsync();
            return Ok(uh.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Uh uh)
        {
            _db.Entry(uh).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var uh = new Uh { ID = id };
            _db.Remove(uh);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
