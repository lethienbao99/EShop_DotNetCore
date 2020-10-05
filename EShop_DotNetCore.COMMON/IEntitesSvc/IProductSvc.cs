using Blog.COMMON.Common;
using EShop_DotNetCore.COMMON.Req.EntitiesReq.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EShop_DotNetCore.COMMON.IEntitesSvc
{
    public interface IProductSvc
    {
        Task<int> Create(ProductCreateReq request);
        Task<bool> Update(ProductUpdateReq request);
        Task<bool> Delete(int id);
        Task<ProductViewModel> GetById(int id);
        Task<List<ProductViewModel>> GetAll();
        Task<PagedResult<ProductViewModel>> GetAllPaging(int Page, int Size);
        Task AddViewCount(int id);
    }
}
