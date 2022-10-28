using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalWebAPI_myProject_.Models;

namespace LocalWebAPI_myProject_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SprovidersController : ControllerBase
    {
        private readonly CUsersfarseenaDesktopLocalBussinessLocalBussinessMiniProjectadminApp_DatademodbmdfContext _context;

        public SprovidersController(CUsersfarseenaDesktopLocalBussinessLocalBussinessMiniProjectadminApp_DatademodbmdfContext context)
        {
            _context = context;
        }

        // GET: api/Sproviders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sprovider>>> GetSproviders()
        {
            return await _context.Sproviders.ToListAsync();
        }

        // GET: api/Sproviders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sprovider>> GetSprovider(int id)
        {
            var sprovider = await _context.Sproviders.FindAsync(id);

            if (sprovider == null)
            {
                return NotFound();
            }

            return sprovider;
        }

        // PUT: api/Sproviders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSprovider(int id, Sprovider sprovider)
        {
            if (id != sprovider.SprovidersId)
            {
                return BadRequest();
            }

            _context.Entry(sprovider).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SproviderExists(id))
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

        // POST: api/Sproviders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sprovider>> PostSprovider(Sprovider sprovider)
        {
            _context.Sproviders.Add(sprovider);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSprovider", new { id = sprovider.SprovidersId }, sprovider);
        }

        // DELETE: api/Sproviders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSprovider(int id)
        {
            var sprovider = await _context.Sproviders.FindAsync(id);
            if (sprovider == null)
            {
                return NotFound();
            }

            _context.Sproviders.Remove(sprovider);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SproviderExists(int id)
        {
            return _context.Sproviders.Any(e => e.SprovidersId == id);
        }
    }
}
