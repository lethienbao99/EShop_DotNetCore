using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.COMMON.Req.EntitiesReq.Users
{
    public class LoginReq
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
