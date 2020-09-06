using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public int ProductId { get; set; }
        public string Url { get; set; }
        public bool IsDefault { get; set; }
        public Product Product { get; set; }
    }
}