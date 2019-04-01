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
    public class ADUserGroupsController : ControllerBase
    {
        private readonly FIDOContext _context;

        public ADUserGroupsController(FIDOContext context)
        {
            _context = context;
        }

        // GET: api/ADUserGroups
        [HttpGet]
        public IEnumerable<ADUserGroup> GetADUserGroups()
        {
            return _context.ADUserGroups;
        }

        // GET: api/ADUserGroups/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetADUserGroup([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var aDUserGroup = await _context.ADUserGroups.FindAsync(id);

            if (aDUserGroup == null)
            {
                return NotFound();
            }

            return Ok(aDUserGroup);
        }

        // PUT: api/ADUserGroups/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutADUserGroup([FromRoute] int id, [FromBody] ADUserGroup aDUserGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aDUserGroup.ADUserGroupID)
            {
                return BadRequest();
            }

            _context.Entry(aDUserGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ADUserGroupExists(id))
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

        // POST: api/ADUserGroups
        [HttpPost]
        public async Task<IActionResult> PostADUserGroup([FromBody] ADUserGroup aDUserGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ADUserGroups.Add(aDUserGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetADUserGroup", new { id = aDUserGroup.ADUserGroupID }, aDUserGroup);
        }

        // DELETE: api/ADUserGroups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteADUserGroup([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var aDUserGroup = await _context.ADUserGroups.FindAsync(id);
            if (aDUserGroup == null)
            {
                return NotFound();
            }

            _context.ADUserGroups.Remove(aDUserGroup);
            await _context.SaveChangesAsync();

            return Ok(aDUserGroup);
        }

        private bool ADUserGroupExists(int id)
        {
            return _context.ADUserGroups.Any(e => e.ADUserGroupID == id);
        }
    }
}