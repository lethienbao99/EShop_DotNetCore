using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShop_DotNetCore.COMMON.IEntitesSvc;
using EShop_DotNetCore.COMMON.Req.EntitiesReq.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop_DotNetCore.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IUsersSvc _userSvc;
        public UsersController(IUsersSvc userSvc)
        {
            _userSvc = userSvc;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromForm] LoginReq req)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var res = await _userSvc.Authenticate(req);

            if (string.IsNullOrEmpty(res))
            {
                return BadRequest("Username or password is incorrect. ");
            }
            return Ok(new { token = res });
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromForm] RegisterReq req)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var res = await _userSvc.Register(req);

            if (!res)
            {
                return BadRequest("Register is unsuccessful");
            }
            return Ok();
        }
    }
}