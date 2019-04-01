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
    public class ADUsersController : ControllerBase
    {
        private readonly FIDOContext _context;

        public ADUsersController(FIDOContext context)
        {
            _context = context;
        }

        // GET: api/ADUsers
        [HttpGet]
        public IEnumerable<ADUser> GetADUsers()
        {
            return _context.ADUsers;
        }

        // GET: api/ADUsers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetADUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var aDUser = await _context.ADUsers.FindAsync(id);

            if (aDUser == null)
            {
                return NotFound();
            }

            return Ok(aDUser);
        }

        // PUT: api/ADUsers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutADUser([FromRoute] int id, [FromBody] ADUser aDUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aDUser.ADUserID)
            {
                return BadRequest();
            }

            _context.Entry(aDUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ADUserExists(id))
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

        // POST: api/ADUsers
        [HttpPost]
        public async Task<IActionResult> PostADUser([FromBody] ADUser aDUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ADUsers.Add(aDUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetADUser", new { id = aDUser.ADUserID }, aDUser);
        }

        // DELETE: api/ADUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteADUser([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var aDUser = await _context.ADUsers.FindAsync(id);
            if (aDUser == null)
            {
                return NotFound();
            }

            _context.ADUsers.Remove(aDUser);
            await _context.SaveChangesAsync();

            return Ok(aDUser);
        }

        private bool ADUserExists(int id)
        {
            return _context.ADUsers.Any(e => e.ADUserID == id);
        }
    }
}