using EShop_DotNetCore.COMMON.Exceptions;
using EShop_DotNetCore.COMMON.IEntitesSvc;
using EShop_DotNetCore.COMMON.Req.EntitiesReq.Users;
using EShop_DotNetCore.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EShop_DotNetCore.BLL.EntitiesSvc
{
    public class UsersSvc : IUsersSvc
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _config;
        public UsersSvc(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
        }
        public async Task<string> Authenticate(LoginReq req)
        {
            var user = await _userManager.FindByNameAsync(req.UserName);

            if (user == null)
                return null;

            var res = await _signInManager.PasswordSignInAsync(user, req.Password, req.RememberMe, true);
            if (!res.Succeeded)
            {
                return null;
            }
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.GivenName, user.FirstName),
                new Claim(ClaimTypes.Role, string.Join(";", roles))
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
            /*ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));*/
        }

        public async Task<bool> Register(RegisterReq req)
        {
            var user = new AppUser()
            {
                UserName = req.UserName,
                FirstName = req.FirstName,
                LastName = req.LastName,
                PhoneNumber = req.PhoneNumber,
                Email = req.Email

            };
            var res = await _userManager.CreateAsync(user, req.Password);
            if (res.Succeeded)
            {
                return true;
            }
            return false;
        }
    }
}