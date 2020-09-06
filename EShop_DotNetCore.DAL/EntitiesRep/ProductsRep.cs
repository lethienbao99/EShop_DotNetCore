using EShop_DotNetCore.COMMON.DAL;
using EShop_DotNetCore.DAL.EF;
using EShop_DotNetCore.DAL.Models;
using EShop_DotNetCore.COMMON.Rsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EShop_DotNetCore.DAL.EntitiesRep
{
    public class ProductsRep : GenericRep<EShopDBContext, Product>
    {
        #region -- Overrides --

        /// <summary>
        /// Read single object
        /// </summary>
        /// <param name="id">Primary key</param>
        /// <returns>Return the object</returns>
        public override Product Read(int id)
        {
            var res = All.FirstOrDefault(p => p.ProductId == id);
            return res;
        }


        /// <summary>
        /// Remove and not restore
        /// </summary>
        /// <param name="id">Primary key</param>
        /// <returns>Number of affect</returns>
        public int Remove(int id)
        {
            var m = base.All.First(i => i.ProductId == id);
            m = base.Delete(m); //TODO
            return m.ProductId;
        }

        #endregion

        

        /// <summary>
        /// Initialize
        /// </summary>

        #region Create Product
        public SingleRsp CreateProduct(Product pro)
        {
            var res = new SingleRsp();
            using (var context = new EShopDBContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Products.Add(pro);
                        context.SaveChanges();
                        tran.Commit();
                    }
                    catch (Exception e)
                    {
                        tran.Rollback();
                        res.SetError(e.StackTrace);
                    }
                }
            }

            return res;
        }

        #endregion
        //=================================================================


        #region Update Product

        public SingleRsp UpdateProduct(Product pro)
        {
            var res = new SingleRsp();
            using (var context = new EShopDBContext())
            {
                using (var tran = context.Database.BeginTransaction())
                {
                    try
                    {
                        var t = context.Products.Update(pro);
                        context.SaveChangesAsync();
                        tran.Commit();
                    }
                    catch (Exception e)
                    {
                        tran.Rollback();
                        res.SetError(e.StackTrace);
                    }
                }
            }

            return res;
        }
        #endregion
        //=================================================================


        #region RemoveProduct

        public bool RemoveProduct(int Id)
        {
            Product pro = Context.Products.FirstOrDefault(x => x.ProductId == Id);
            if (pro == null) return false;
            Context.Products.Remove(pro);
            Context.SaveChanges();
            return true;
        }
        #endregion

        #region Get ViewCount 
        public bool AddViewCount(int Id)
        {
            var product = Context.Products.Find(Id);
            product.ViewCount += 1;
            Context.SaveChanges();
            return true;
        }
        #endregion


    }
}
