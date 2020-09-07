using EShop_DotNetCore.COMMON.Req.EntitiesReq.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EShop_DotNetCore.COMMON.IEntitesSvc
{
    public interface IUsersSvc
    {
        Task<string> Authenticate(LoginReq req);
        Task<bool> Register(RegisterReq req);
    }
}