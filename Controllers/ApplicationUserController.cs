using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using theaterlaak.Data;
using theaterlaak.Models;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace theaterlaak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationUserController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
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

        [HttpGet("current")]
        public async Task<ActionResult<ApplicationUser>> GetCurrentUserIdAsync()
        {
            ApplicationUser usr = await GetCurrentUserAsync();
            // string userId = await _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;        
            return usr;
        }

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        }
}