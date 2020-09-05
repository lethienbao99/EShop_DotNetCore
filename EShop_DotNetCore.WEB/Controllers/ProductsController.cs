using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShop_DotNetCore.BLL.EntitiesSvc;
using EShop_DotNetCore.COMMON.Rsp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop_DotNetCore.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsSvc _svc;

        public ProductsController()
        {
            _svc = new ProductsSvc();
        }
        [HttpGet("{Id}")]
        public IActionResult GetProductById(int Id)
        {
            var res = new SingleRsp();
            var product = _svc.GetProductById(Id);
            res.Data = product;

            return Ok(res);
        }
    }
}
