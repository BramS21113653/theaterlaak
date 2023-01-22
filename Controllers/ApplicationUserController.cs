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
    public class ApplicationUserController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public ApplicationUserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationUser>> GetApplicationUser(string id)
        {
            var applicationUser = await _context.ApplicationUsers.FindAsync(id);

            if (applicationUser == null)
            {
                return NotFound();
            }

            return applicationUser;
        }


        // [Authorize(Roles = "ACTEUR")]
        [HttpPut]
        public async Task<ActionResult<ApplicationUser>> UpdateApplicationUser(ApplicationUser applicationUser)
        {
            try {
                using (var ctx = _context) {
                    var existingApplicationUser = ctx.ApplicationUsers.Where(s => s.Id == applicationUser.Id)
                                                            .FirstOrDefault<ApplicationUser>();

                    if (existingApplicationUser != null)
                    {
                        existingApplicationUser.groepId = applicationUser.groepId;
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