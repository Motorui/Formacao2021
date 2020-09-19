using Formacao2021.Server.Data;
using Formacao2021.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Formacao2021.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly AppDBContext _db;
        public DeveloperController(AppDBContext context)
        {
            this._db = context;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    var devs = await _db.Developers.ToListAsync();
        //    return Ok(devs);
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(int id)
        //{
        //    var dev = await _db.Developers.FirstOrDefaultAsync(a => a.Id == id);
        //    return Ok(dev);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Post(Developer developer)
        //{
        //    _db.Add(developer);
        //    await _db.SaveChangesAsync();
        //    return Ok(developer.Id);
        //}

        //[HttpPut]
        //public async Task<IActionResult> Put(Developer developer)
        //{
        //    _db.Entry(developer).State = EntityState.Modified;
        //    await _db.SaveChangesAsync();
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var dev = new Developer { Id = id };
        //    _db.Remove(dev);
        //    await _db.SaveChangesAsync();
        //    return NoContent();
        //}
    }
}
