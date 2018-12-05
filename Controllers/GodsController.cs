using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using final.Models;

namespace Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GodsController : ControllerBase
    {
        private readonly FinalContext _context;

        public GodsController(FinalContext context)
        {
            _context = context;
        }

        // GET: api/Gods
        [HttpGet]
        public IEnumerable<God> GetGod()
        {
            return _context.God;
        }

        // GET: api/Gods/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGod([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var god = await _context.God.FindAsync(id);

            if (god == null)
            {
                return NotFound();
            }

            return Ok(god);
        }

        // PUT: api/Gods/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGod([FromRoute] int id, [FromBody] God god)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != god.ID)
            {
                return BadRequest();
            }

            _context.Entry(god).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GodExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Gods
        [HttpPost]
        public async Task<IActionResult> PostGod([FromBody] God god)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.God.Add(god);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGod", new { id = god.ID }, god);
        }

        // DELETE: api/Gods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGod([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var god = await _context.God.FindAsync(id);
            if (god == null)
            {
                return NotFound();
            }

            _context.God.Remove(god);
            await _context.SaveChangesAsync();

            return Ok(god);
        }

        private bool GodExists(int id)
        {
            return _context.God.Any(e => e.ID == id);
        }
    }
}