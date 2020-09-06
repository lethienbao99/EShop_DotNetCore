using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.COMMON.Req.EntitiesReq.Products
{
    public class ProductUpdateReq
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Detail { get; set; }
        public int Stock { get; set; }

    }
}