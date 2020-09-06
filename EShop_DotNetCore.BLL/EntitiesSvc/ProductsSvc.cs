using EShop_DotNetCore.COMMON.BLL;
using EShop_DotNetCore.COMMON.Rsp;
using EShop_DotNetCore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net.Mime;
using System.Net.Http.Headers;
using System.IO;
using EShop_DotNetCore.COMMON.Req.EntitiesReq;
using EShop_DotNetCore.DAL.EF;
using System.Security.Cryptography;
using EShop_DotNetCore.DAL.EntitiesRep;
using EShop_DotNetCore.COMMON.Req.EntitiesReq.Products;
using EShop_DotNetCore.COMMON.Req;

namespace EShop_DotNetCore.BLL.EntitiesSvc
{
    public class ProductsSvc : GenericSvc<ProductsRep, Product>
    {
        #region -- Overrides --

        /// <summary>
        /// Read single object
        /// </summary>
        /// <param name="id">Primary key</param>
        /// <returns>Return the object</returns>
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();

            var m = _rep.Read(id);
            res.Data = m;

            return res;
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="m">The model</param>
        /// <returns>Return the result</returns>
        public override SingleRsp Update(Product m)
        {
            var res = new SingleRsp();

            var m1 = m.ProductId > 0 ? _rep.Read(m.ProductId) : _rep.Read(m.Description);
            if (m1 == null)
            {
                res.SetError("EZ103", "No data.");
            }
            else
            {
                res = base.Update(m);
                res.Data = m;
            }

            return res;
        }
        #endregion

        #region -- Methods --

        public ProductsSvc() { }

        public object GetProductById(int Id)
        {
            var product = from p in _rep.Context.Products
                          where p.ProductId == Id
                          select new
                          {
                              Id = p.ProductId,
                              Name = p.Name,
                              Categories = (from c in _rep.Context.Categories
                                            join pc in _rep.Context.ProductCategories on c.CategoryId equals pc.CategoryId
                                            where c.CategoryId == pc.CategoryId && p.ProductId == pc.ProductId
                                            select new
                                            {
                                                Name = c.Name
                                            }).FirstOrDefault(),
                              Description = p.Description,
                              Price = p.Price,
                              Detail = p.Detail,
                              Stock = p.Stock,
                              Images = (from i in _rep.Context.Images
                                        where i.ProductId == p.ProductId
                                        select new
                                        {
                                            Id = i.ImageId,
                                            Url = i.Url,
                                            IsDefault = i.IsDefault
                                        }).ToList(),
                              DateCreated = p.DateCreated
                          };
            return product;
        }

        public object GetAllProductPaging(int Page, int Size)
        {
            var product = from p in _rep.Context.Products
                          select new
                          {
                              Id = p.ProductId,
                              Name = p.Name,
                              Categories = (from c in _rep.Context.Categories
                                            join pc in _rep.Context.ProductCategories on c.CategoryId equals pc.CategoryId
                                            where c.CategoryId == pc.CategoryId && p.ProductId == pc.ProductId
                                            select new
                                            {
                                                Name = c.Name
                                            }).FirstOrDefault(),
                              Description = p.Description,
                              Price = p.Price,
                              Detail = p.Detail,
                              Stock = p.Stock,
                              Images = (from i in _rep.Context.Images
                                        where i.ProductId == p.ProductId
                                        select new
                                        {
                                            Id = i.ImageId,
                                            Url = i.Url,
                                            IsDefault = i.IsDefault
                                        }).ToList(),
                              DateCreated = p.DateCreated
                          };

            var offset = (Page - 1) * Size;
            var total = product.Count();
            int totalpage = (total % Size) == 0 ? (total / Size) : (int)((total / Size) + 1);
            var data = product.OrderBy(x => x.Id).Skip(offset).Take(Size).ToList();
            var res = new
            {
                Data = data,
                TotalRecord = total,
                TotalPage = totalpage,
                Page = Page,
                Size = Size
            };

            return res;
        }

        public SingleRsp CreateProduct(ProductCreateReq pro)
        {
            var res = new SingleRsp();
            Product product = new Product();
            product.Name = pro.Name;
            product.Price = pro.Price;
            product.Description = pro.Description;
            product.Detail = pro.Detail;
            product.Stock = pro.Stock;
            product.Slug = pro.Slug;
            product.DateCreated = DateTime.Now;
            res = _rep.CreateProduct(product);
            return res;
        }

        public SingleRsp UpdateProduct(ProductUpdateReq pro)
        {
            var res = new SingleRsp();
            Product product = new Product();
            product.ProductId = pro.ProductId;
            product.Name = pro.Name;
            product.Price = pro.Price;
            product.Description = pro.Description;
            product.Detail = pro.Detail;
            product.Stock = pro.Stock;
            res = _rep.CreateProduct(product);
            return res;
        }

        public bool RemoveProduct(int Id)
        {
            Product pro = _rep.Context.Products.FirstOrDefault(x => x.ProductId == Id);
            if (pro == null) return false;
            var images = _rep.Context.Images.Where(i => i.ProductId == Id);
            foreach (var image in images.ToList())
            {
                _rep.Context.Images.Remove(image);
            }
            _rep.Context.Products.Remove(pro);
            _rep.Context.SaveChanges();
            return true;
        }




        #endregion
        //===========================================================
    }
}