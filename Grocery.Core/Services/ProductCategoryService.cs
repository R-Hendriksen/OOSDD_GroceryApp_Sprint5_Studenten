using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Core.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryService _productCategoryService;

        public ProductCategoryService(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }
        public List<ProductCategory> GetAll()
        {
            return _productCategoryService.GetAll();
        }

        public ProductCategory Add(ProductCategory item)
        {
            throw new NotImplementedException();
        }

        public ProductCategory? Delete(ProductCategory item)
        {
            throw new NotImplementedException();
        }

        public ProductCategory? Get(int id)
        {
            return _productCategoryService.Get(id);
        }

        public ProductCategory? Update(ProductCategory item)
        {
            throw new NotImplementedException();
        }
    }
}
