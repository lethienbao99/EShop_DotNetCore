using EShop_DotNetCore.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop_DotNetCore.DAL.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }
        public Status Status { get; set; }
        public string Slug { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
