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
    public class GroepController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public GroepController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Groep>> GetGroep(string id)
        {
            var groep = await _context.Groepen.FindAsync(id);

            if (groep == null)
            {
                return NotFound();
            }

            return groep;
        }

        // [Authorize(Roles = "ADMIN")]
        [HttpPost]
        public async Task<ActionResult<Groep>> PostGroep(Groep groep)
        {
            // Console.WriteLine(groep); 
            _context.Groepen.Add(groep);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetGroep), new { id = groep.groepId }, groep);
        }

        // [Authorize(Roles = "ACTEUR")]
        [HttpPut]
        public async Task<ActionResult<Groep>> UpdateGroep(Groep groep)
        {
            try {
                using (var ctx = _context) {
                    var existingGroep = ctx.Groepen.Where(s => s.groepId == groep.groepId)
                                                            .FirstOrDefault<Groep>();

                    if (existingGroep != null)
                    {
                        // existingGroep.groepId = groep.groepId;
                        existingGroep.naam = groep.naam;
                        existingGroep.website = groep.website;
                        // existingGroep = groep;
                        await ctx.SaveChangesAsync();
                        return Ok();

                    }
                    else
                    {
                        return NotFound();
                    }
                }
            }
            catch (Exception)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                        "Error updating data");
                }
        }
    }
}
