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
    public class ZitplaatsController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public ZitplaatsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Zitplaats>> GetZitplaats(string id)
        {
            var zitplaats = await _context.Zitplaatsen.FindAsync(id);

            if (zitplaats == null)
            {
                return NotFound();
            }

            return zitplaats;
        }

        // [Authorize(Roles = "ADMIN")]
        [HttpPost]
        public async Task<ActionResult<Zitplaats>> PostZitplaats(Zitplaats zitplaats)
        {
            _context.Zitplaatsen.Add(zitplaats);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetZitplaats), new { id = zitplaats.zitplaatsId }, zitplaats);
        }
    }
}
