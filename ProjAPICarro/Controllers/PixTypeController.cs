using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using ProjAPICarro.Data;

namespace ProjAPICarro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PixTypeController : ControllerBase
    {
        private readonly ProjAPICarroContext _context;

        public PixTypeController(ProjAPICarroContext context)
        {
            _context = context;
        }

        // GET: api/PixType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PixType>>> GetPixType()
        {
            return await _context.PixType.ToListAsync();
        }

        // GET: api/PixType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PixType>> GetPixType(int id)
        {
            var pixType = await _context.PixType.FindAsync(id);

            if (pixType == null)
            {
                return NotFound();
            }

            return pixType;
        }

        // PUT: api/PixType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPixType(int id, PixType pixType)
        {
            if (id != pixType.Id)
            {
                return BadRequest();
            }

            _context.Entry(pixType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PixTypeExists(id))
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

        // POST: api/PixType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PixType>> PostPixType(PixType pixType)
        {
            _context.PixType.Add(pixType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPixType", new { id = pixType.Id }, pixType);
        }

        // DELETE: api/PixType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePixType(int id)
        {
            var pixType = await _context.PixType.FindAsync(id);
            if (pixType == null)
            {
                return NotFound();
            }

            _context.PixType.Remove(pixType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PixTypeExists(int id)
        {
            return _context.PixType.Any(e => e.Id == id);
        }
    }
}
