using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShop_DotNetCore.COMMON.IEntitesSvc;
using EShop_DotNetCore.COMMON.Req.EntitiesReq.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop_DotNetCore.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductSvc _productSvc;
        public ProductsController(IProductSvc productSvc)
        {
            _productSvc = productSvc;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productSvc.GetAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var products = await _productSvc.GetById(id);
            return Ok(products);
        }

        [HttpGet("Paging")]
        public async Task<IActionResult> GetAllPaging(int Page, int Size)
        {
            var products = await _productSvc.GetAllPaging(Page, Size);
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateReq req)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productId = await _productSvc.Create(req);

            if (productId == 0)
                return BadRequest();
            var product = await _productSvc.GetById(productId);
            return CreatedAtAction(nameof(GetById), new { id = productId }, product);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductUpdateReq req)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var product = await _productSvc.Update(req);

            if (product == false)
                return BadRequest();
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productSvc.Delete(id);
            if (product == false)
                return BadRequest();
            return Ok(product);
        }
    }
}
