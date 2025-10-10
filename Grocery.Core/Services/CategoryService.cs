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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryService _categoryService;

        public CategoryService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public List<Category> GetAll()
        {
            return _categoryService.GetAll();
        }

        public Category Add(Category item)
        {
            throw new NotImplementedException();
        }

        public Category? Delete(Category item)
        {
            throw new NotImplementedException();
        }

        public Category? Get(int id)
        {
            return _categoryService.Get(id);
        }

        public Category? Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
