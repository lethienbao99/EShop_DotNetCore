using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Models
{
    public class OrderDetail
    {

        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }


        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}
