using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FIDO_BE.Data;
using FIDO_BE.Models;

namespace FIDO_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GENumberingsController : ControllerBase
    {
        private readonly FIDOContext _context;

        public GENumberingsController(FIDOContext context)
        {
            _context = context;
        }

        // GET: api/GENumberings
        [HttpGet]
        public IEnumerable<GENumbering> GetGENumberings()
        {
            return _context.GENumberings;
        }

        // GET: api/GENumberings/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGENumbering([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var gENumbering = await _context.GENumberings.FindAsync(id);

            if (gENumbering == null)
            {
                return NotFound();
            }

            return Ok(gENumbering);
        }

        // PUT: api/GENumberings/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGENumbering([FromRoute] int id, [FromBody] GENumbering gENumbering)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gENumbering.GENumberingID)
            {
                return BadRequest();
            }

            _context.Entry(gENumbering).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GENumberingExists(id))
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

        // POST: api/GENumberings
        [HttpPost]
        public async Task<IActionResult> PostGENumbering([FromBody] GENumbering gENumbering)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.GENumberings.Add(gENumbering);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGENumbering", new { id = gENumbering.GENumberingID }, gENumbering);
        }

        // DELETE: api/GENumberings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGENumbering([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var gENumbering = await _context.GENumberings.FindAsync(id);
            if (gENumbering == null)
            {
                return NotFound();
            }

            _context.GENumberings.Remove(gENumbering);
            await _context.SaveChangesAsync();

            return Ok(gENumbering);
        }

        private bool GENumberingExists(int id)
        {
            return _context.GENumberings.Any(e => e.GENumberingID == id);
        }
    }
}