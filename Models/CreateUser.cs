// using Microsoft.AspNetCore.Identity;
// using theaterlaak.Models;

// class CreateUser : ApplicationUser {
//     private readonly UserManager<ApplicationUser> _userManager;
//     private readonly RoleManager<IdentityRole> _roleManager;

//     public CreateUser(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
//         {
//             _userManager = userManager;
//             _signInManager = signInManager;
//         }
//     public async Task CreateRolesandUsers() {  
//         bool x = await _roleManager.RoleExistsAsync("Admin");
//         if (!x)
//         {
//             // first we create Admin rool    
//             var role = new IdentityRole();
//             role.Name = "Admin";
//             await _roleManager.CreateAsync(role);

//             //Here we create a Admin super user who will maintain the website                   

//             var user = new ApplicationUser();
//             user.UserName = "Admin";
//             user.Email = "Admin@test.nl";

//             string userPWD = "Test!123";

//             IdentityResult chkUser = await _userManager.CreateAsync(user, userPWD);

//             //Add default User to Role Admin    
//             if (chkUser.Succeeded)
//             {
//                 var result1 = await _userManager.AddToRoleAsync(user, "Admin");
//             }
//         }
//     }
// }