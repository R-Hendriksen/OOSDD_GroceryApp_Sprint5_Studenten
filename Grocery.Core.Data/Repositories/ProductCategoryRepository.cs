using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Core.Data.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly List<ProductCategory> productCategories;
        public ProductCategoryRepository()
        {
            productCategories = [
                new ProductCategory(1, "Zuivel", 1, 1),
                new ProductCategory(1, "Zuivel", 2, 1),
                new ProductCategory(2, "Graanproduct", 3, 2),
                new ProductCategory(3, "Maïsproduct", 4, 3)
                ];
        }

        public List<ProductCategory> GetAll()
        {
            return productCategories;
        }

        public ProductCategory? Get(int id)
        {
            return productCategories.SingleOrDefault(pc => pc.Id == id);
        }
    }
}

