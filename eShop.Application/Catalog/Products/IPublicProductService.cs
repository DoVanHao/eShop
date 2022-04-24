
using eShop.ViewModel.Catalog.Products;
using eShop.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryID(GetPublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll();
    }
}
