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
    public class ForumDetailsController : ControllerBase
    {
        private readonly FIDOContext _context;

        public ForumDetailsController(FIDOContext context)
        {
            _context = context;
        }

        // GET: api/ForumDetails
        [HttpGet]
        public IEnumerable<ForumDetail> GetForumDetails()
        {
            return _context.ForumDetails;
        }

        // GET: api/ForumDetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetForumDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var forumDetail = await _context.ForumDetails.FindAsync(id);

            if (forumDetail == null)
            {
                return NotFound();
            }

            return Ok(forumDetail);
        }

        // PUT: api/ForumDetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutForumDetail([FromRoute] int id, [FromBody] ForumDetail forumDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != forumDetail.ForumDetailID)
            {
                return BadRequest();
            }

            _context.Entry(forumDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ForumDetailExists(id))
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

        // POST: api/ForumDetails
        [HttpPost]
        public async Task<IActionResult> PostForumDetail([FromBody] ForumDetail forumDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ForumDetails.Add(forumDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetForumDetail", new { id = forumDetail.ForumDetailID }, forumDetail);
        }

        // DELETE: api/ForumDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForumDetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var forumDetail = await _context.ForumDetails.FindAsync(id);
            if (forumDetail == null)
            {
                return NotFound();
            }

            _context.ForumDetails.Remove(forumDetail);
            await _context.SaveChangesAsync();

            return Ok(forumDetail);
        }

        private bool ForumDetailExists(int id)
        {
            return _context.ForumDetails.Any(e => e.ForumDetailID == id);
        }
    }
}