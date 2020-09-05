using EShop_DotNetCore.COMMON.BLL;
using EShop_DotNetCore.COMMON.Rsp;
using EShop_DotNetCore.DAL.EntitiesRep;
using EShop_DotNetCore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        /// <summary>
        /// Initialize
        /// </summary>
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
                                            }).ToList(),
                              Description = p.Description,
                              Price = p.Price,
                              Detail = p.Detail,
                              Stock = p.Stock,
                              DateCreated = DateTime.Now
                          };
            return product;
        }


        #endregion
        //===========================================================
    }
}
