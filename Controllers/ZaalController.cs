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
    public class ZaalController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public ZaalController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Zaal>> GetZaal(string id)
        {
            var zaal = await _context.Zalen.FindAsync(id);

            if (zaal == null)
            {
                return NotFound();
            }

            return zaal;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Zaal>> GetAll()
            {
                var zalen = await _context.Zalen.ToListAsync();
                foreach (var zaal in zalen) {
                    var aantalZitplaatsen = await _context.Zitplaatsen.Where(zitplaats => zitplaats.zaalId == zaal.zaalId).CountAsync();
                    zaal.aantalZitplaatsen = aantalZitplaatsen;
                }
                return zalen;
            }

        [Authorize(Roles = "ADMIN")]
        [HttpPost]
        public async Task<ActionResult<Zaal>> PostZaal(Zaal zaal)
        {
            _context.Zalen.Add(zaal);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetZaal), new { id = zaal.zaalId }, zaal);
        }
    }
}
