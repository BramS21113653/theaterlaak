using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using theaterlaak.Data;
using theaterlaak.Models;

namespace theaterlaak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GelegenheidController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public GelegenheidController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Gelegenheid>> GetGelegenheid(string id)
        {
            var gelegenheid = await _context.Gelegenheden.FindAsync(id);

            if (gelegenheid == null)
            {
                return NotFound();
            }

            return gelegenheid;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Gelegenheid>> GetAll()
            {
                var gelegenheden = await _context.Gelegenheden.ToListAsync();
                foreach (var gelegenheid in gelegenheden) {
                    Voorstelling voorstelling = await _context.Voorstellingen.Where(voorstelling => voorstelling.voorstellingId == gelegenheid.voorstellingId).FirstAsync();
                    gelegenheid.voorstelling.titel = voorstelling.titel;
                }
                return gelegenheden;
            }

        [Authorize(Roles = "ADMIN")]
        [HttpPost]
        public async Task<ActionResult<Gelegenheid>> PostGelegenheid(Gelegenheid gelegenheid)
        {
            _context.Gelegenheden.Add(gelegenheid);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGelegenheid), new { id = gelegenheid.gelegenheidId }, gelegenheid);
        }
    }
}
