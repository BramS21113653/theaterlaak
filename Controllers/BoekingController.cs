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
    public class BoekingController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public BoekingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Boeking>> GetBoeking(string id)
        {
            var boeking = await _context.Boekingen.FindAsync(id);

            if (boeking == null)
            {
                return NotFound();
            }

            return boeking;
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost]
        public async Task<ActionResult<Boeking>> PostBoeking(Boeking boeking)
        {
            _context.Boekingen.Add(boeking);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBoeking), new { id = boeking.boekingId }, boeking);
        }
    }
}
