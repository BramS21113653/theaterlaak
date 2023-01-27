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
    public class VoorstellingController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public VoorstellingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Voorstelling>> GetVoorstelling(string id)
        {
            var voorstelling = await _context.Voorstellingen.FindAsync(id);

            if (voorstelling == null)
            {
                return NotFound();
            }

            return voorstelling;
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost]
        public async Task<ActionResult<Voorstelling>> PostVoorstelling(Voorstelling voorstelling)
        {
            _context.Voorstellingen.Add(voorstelling);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetVoorstelling), new { id = voorstelling.voorstellingId }, voorstelling);
        }
    }
}
