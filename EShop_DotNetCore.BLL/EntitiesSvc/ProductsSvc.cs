using EShop_DotNetCore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Net.Mime;
using System.Net.Http.Headers;
using System.IO;
using EShop_DotNetCore.COMMON.Req.EntitiesReq;
using EShop_DotNetCore.DAL.EF;
using System.Security.Cryptography;
using EShop_DotNetCore.COMMON.Req.EntitiesReq.Products;
using EShop_DotNetCore.COMMON.Req;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EShop_DotNetCore.COMMON.IEntitesSvc;
using Blog.COMMON.Common;
using System.Runtime.CompilerServices;
using EShop_DotNetCore.COMMON.Exceptions;

namespace EShop_DotNetCore.BLL.EntitiesSvc
{
    public class ProductsSvc : IProductSvc
    {
        private readonly EShopDBContext _context;
        public ProductsSvc(EShopDBContext context)
        {
            _context = context;
        }
        public Task AddViewCount(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Create(ProductCreateReq request)
        {
            var product = new Product()
            {
               Name = request.Name,
               Description = request.Description,
               Price = request.Price,
               Detail = request.Detail,
               Stock = request.Stock,
               ViewCount = request.ViewCount,
               Slug = request.Slug,
               DateCreated = DateTime.Now
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.ProductId;
        }

        public async Task<bool> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            var images = _context.Images.Where(x => x.ProductId == id);
            var categories = _context.ProductCategories.Where(x => x.ProductId == id);
            foreach (var image in images)
            {
                _context.Images.Remove(image);
            }

            foreach (var category in categories)
            {
                _context.ProductCategories.Remove(category);
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }

        

        public async Task<List<ProductViewModel>> GetAll()
        {
            var query = from p in _context.Products
                             //List Categories
                         let categories = (from pc in _context.ProductCategories
                                           join c in _context.Categories on pc.CategoryId equals c.CategoryId
                                           where p.ProductId == pc.ProductId
                                           select c.Name).ToList()
                         //List Images
                         let images = (from i in _context.Images
                                       where p.ProductId == i.ProductId
                                       select i.Url).ToList()

                         select new
                         {
                             p,
                             categories,
                             images
                         };
            var data = await query.Select(x => new ProductViewModel()
            {
                ProductId = x.p.ProductId,
                Name = x.p.Name,
                Description = x.p.Description,
                Price = x.p.Price,
                Detail = x.p.Detail,
                Stock = x.p.Stock,
                ViewCount = x.p.ViewCount,
                Categories = x.categories,
                Images = x.images
            }).ToListAsync();
            return data;
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(int Page, int Size)
        {
            var query = (from p in _context.Products
                            //List Categories
                        let categories = (from pc in _context.ProductCategories
                                          join c in _context.Categories on pc.CategoryId equals c.CategoryId
                                          where p.ProductId == pc.ProductId
                                          select c.Name).ToList()
                        //List Images
                        let images = (from i in _context.Images
                                      where p.ProductId == i.ProductId
                                      select i.Url).ToList()
                        select new
                        {
                            p,
                            categories,
                            images
                        });

            var data = query.Select(x => new ProductViewModel()
            {
                ProductId = x.p.ProductId,
                Name = x.p.Name,
                Description = x.p.Description,
                Price = x.p.Price,
                Detail = x.p.Detail,
                Stock = x.p.Stock,
                ViewCount = x.p.ViewCount,
                Categories = x.categories,
                Images = x.images
            });
            var DataPaging = await data.Skip((Page - 1) * Size)
                .Take(Size).ToListAsync();

            int totalRow = DataPaging.Count();

            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecords = totalRow,
                PageSize = Size,
                PageIndex = Page,
                Items = DataPaging
            };
            return pagedResult;
        }

        public async Task<ProductViewModel> GetById(int id)
        {
            var product = await _context.Products.FindAsync(id);

            var categories = await (from pc in _context.ProductCategories
                              join c in _context.Categories on pc.CategoryId equals c.CategoryId
                              where id == pc.ProductId
                              select c.Name).ToListAsync();

            var images = await (from i in _context.Images
                          where id == i.ProductId
                          select i.Url).ToListAsync();

            var data = new ProductViewModel()
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Detail = product.Detail,
                Stock = product.Stock,
                ViewCount = product.ViewCount,
                Categories = categories,
                Images = images
            };
            return data;
        }

        public async Task<bool> Update(ProductUpdateReq request)
        {
            var product = await _context.Products.FindAsync(request.ProductId);
            if (product == null) throw new EShopException($"Cannot find a Product: {request.ProductId}");
            product.Name = request.Name;
            product.Description = request.Description;
            product.Price = request.Price;
            product.Detail = request.Detail;

            _context.Products.Update(product);

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
