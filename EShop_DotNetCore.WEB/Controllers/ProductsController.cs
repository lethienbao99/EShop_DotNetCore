using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShop_DotNetCore.BLL.EntitiesSvc;
using EShop_DotNetCore.COMMON.Req;
using EShop_DotNetCore.COMMON.Req.EntitiesReq;
using EShop_DotNetCore.COMMON.Req.EntitiesReq.Products;
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

        [HttpGet]
        public IActionResult GetAllProductPaging(int Page, int Size)
        {
            var res = new SingleRsp();
            var products = _svc.GetAllProductPaging(Page, Size);
            res.Data = products;
            return Ok(res);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromForm] ProductCreateReq req)
        {
            var res = _svc.CreateProduct(req);
            return Ok(res);
        }
        [HttpPut]
        public IActionResult UpdateProduct([FromForm] ProductUpdateReq req)
        {
            var res = _svc.UpdateProduct(req);
            return Ok(res);
        }
        [HttpDelete("{Id}")]
        public IActionResult RemoveProduct(int Id)
        {
            var res = _svc.RemoveProduct(Id);
            return Ok(res);
        }
    }
}
