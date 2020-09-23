using Formacao2021.Server.Data;
using Formacao2021.Server.Models.Identity;
using Formacao2021.Shared.Models.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Formacao2021.Server.Controllers.Identity
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDBContext _db;

        public AuthController(UserManager<AppUser> userManager,
            RoleManager<AppRole> roleManager,
            SignInManager<AppUser> signInManager,
            AppDBContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _db = context;
        }

        #region User
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userManager.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(a => a.Id == id.ToString());
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUser parameters)
        {
            var user = new AppUser
            {
                Name = parameters.Name,
                UserName = parameters.UserName,
                Email = parameters.Email             
            };

            var result = await _userManager.CreateAsync(user, parameters.Password);
            if (!result.Succeeded) return BadRequest(result.Errors.FirstOrDefault()?.Description);
            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> Update(RegisterUser parameters)
        {
            var user = await _userManager.FindByIdAsync(parameters.Id.ToString());

            user.Name = parameters.Name;
            user.UserName = parameters.UserName;
            user.Email = parameters.Email;
            if (parameters.Password != null)
            {
                user.PasswordHash = parameters.Password;
            }

            await _userManager.UpdateAsync(user);
            return NoContent();
        }

        //Login – Controller Method
        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null) return BadRequest("Esse utilizador não existe");
            var singInResult = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if (!singInResult.Succeeded) return BadRequest("Password inválida");
            await _signInManager.SignInAsync(user, request.RememberMe);
            return Ok();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }

        [HttpGet]
        public CurrentUser CurrentUserInfo()
        {
            return new CurrentUser
            {
                IsAuthenticated = User.Identity.IsAuthenticated,
                UserName = User.Identity.Name,
                Claims = User.Claims
                .ToDictionary(c => c.Type, c => c.Value)
            };
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(id.ToString());

                await _userManager.DeleteAsync(user);
                return NoContent();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region UserRoles
        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return Ok(roles);
        }

        [HttpGet]
        public async Task<IActionResult> GetUserRoles()
        {
            var userRoles = await _db.UserRoles.ToListAsync();
            return Ok(userRoles);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUserRoles(RegisterUserRole userRole)
        {
            var appUserRole = new AppUserRole()
            {
                RoleId = userRole.RoleId.ToString(),
                UserId = userRole.UserId.ToString()
            };
            _db.UserRoles.Add(appUserRole);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserRoles(Guid id)
        {
            var userRoles = await _db.UserRoles.Where(u => u.UserId == id.ToString()).ToListAsync();

            foreach (var userRole in userRoles)
            {
                _db.Remove(userRole);
            }

            await _db.SaveChangesAsync();
            return NoContent();
        }
        #endregion
        #region UserUhs
        [HttpGet]
        public async Task<IActionResult> GetUserUhs()
        {
            var userUhs = await _db.UsersUhs.ToListAsync();
            return Ok(userUhs);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUserUhs(RegisterUserUh userUh)
        {
            var u = new UserUh()
            {
                UhID = userUh.UhID,
                UserId = userUh.UserId
            };
            _db.UsersUhs.Add(u);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserUhs(Guid id)
        {
            var userUhs = await _db.UsersUhs.Where(u=>u.UserId == id).ToListAsync();

            foreach (var userUh in userUhs)
            {
                _db.Remove(userUh);
            }

            await _db.SaveChangesAsync();
            return NoContent();
        }
        #endregion
    }
}
