using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.COMMON.Req.EntitiesReq.Products
{
    public class ProductCreateReq
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Detail { get; set; }
        public int Stock { get; set; }
        public string Slug { get; set; }

    }
}
