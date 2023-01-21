using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
