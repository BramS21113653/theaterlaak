using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using theaterlaak.Data;
using theaterlaak.Models;

namespace theaterlaak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetalingController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public BetalingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost, Consumes("application/x-www-form-urlencoded")]
        public async Task<IActionResult> Post([FromForm]Betaling betaling)
        {
            try {
                _context.Betalingen.Add(betaling);
                await _context.SaveChangesAsync();
                if (betaling.succes == true) {
                    return base.Content("<div><h1>De betaling is geslaagd.</h1><a href='https://localhost:44474/tickets'>Klik hier om terug te gaan</a></div>", "text/html");
                } else {
                    return base.Content("<div><h1>De betaling is NIET geslaagd.</h1><a href='https://localhost:44474'>Klik hier om terug te gaan</a></div>", "text/html");
                }
            } catch(Exception e) {
                return base.Content("<div>Er is een onverwachte fout opgetreden...</div>", "text/html");
            }
        }
    }
}
