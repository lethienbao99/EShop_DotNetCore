using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.COMMON.Req.EntitiesReq.Products
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Detail { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public string Slug { get; set; }
        public DateTime DateCreated { get; set; }
        public List<string> Categories { get; set; } = new List<string>();
        public List<string> Images { get; set; } = new List<string>();
    }
}
