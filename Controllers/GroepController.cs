using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            // var todoItem = await _context.TodoItems.FindAsync(id);

            if (groep == null)
            {
                return NotFound();
            }

            return groep;
        }

        [HttpPost]
        public async Task<ActionResult<Groep>> PostGroep(Groep groep)
        {
            _context.Groepen.Add(groep);
            await _context.SaveChangesAsync();

            //    return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetGroep), new { id = groep.groepId }, groep);
        }

        // public string Get()
        // {
        //     return "welcome";
        // }
    }
}
