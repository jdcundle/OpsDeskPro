using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpsDeskProAPI.Models;

namespace OpsDeskProAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private readonly OpsDeskProContext _context;

        public InstructorController(OpsDeskProContext context)
        {
            _context = context;
        }

        // GET: api/Instructor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Instructor>>> GetInstructor()
        {
            return await _context.Instructor.ToListAsync();
        }

        // GET: api/Instructor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Instructor>> GetInstructor(Guid id)
        {
            var instructor = await _context.Instructor.FindAsync(id);

            if (instructor == null)
            {
                return NotFound();
            }

            return instructor;
        }

        // PUT: api/Instructor/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstructor(Guid id, Instructor instructor)
        {
            if (id != instructor.ID)
            {
                return BadRequest();
            }

            _context.Entry(instructor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstructorExists(id))
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

        // POST: api/Instructor
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Instructor>> PostInstructor(Instructor instructor)
        {
            _context.Instructor.Add(instructor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstructor", new { id = instructor.ID }, instructor);
        }

        // DELETE: api/Instructor/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Instructor>> DeleteInstructor(Guid id)
        {
            var instructor = await _context.Instructor.FindAsync(id);
            if (instructor == null)
            {
                return NotFound();
            }

            _context.Instructor.Remove(instructor);
            await _context.SaveChangesAsync();

            return instructor;
        }

        private bool InstructorExists(Guid id)
        {
            return _context.Instructor.Any(e => e.ID == id);
        }
    }
}
