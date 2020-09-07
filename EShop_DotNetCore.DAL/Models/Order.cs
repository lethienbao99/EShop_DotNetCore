using EShop_DotNetCore.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Models
{
    public class Order
    {
        public int OrderId { set; get; }
        public DateTime OrderDate { set; get; }
        public Guid UserId { set; get; }
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipEmail { set; get; }
        public string ShipNumberPhone { set; get; }
        public OrderStatus Status { set; get; }
        public List<OrderDetail> OrderDetails { get; set; }
        public AppUser AppUser { get; set; }



    }
}
