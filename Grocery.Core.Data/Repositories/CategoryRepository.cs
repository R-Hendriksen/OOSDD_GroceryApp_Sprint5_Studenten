using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Core.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly List<Category> categories;
        public CategoryRepository()
        {
            categories = [
                new Category(1, "Zuivel"),
                new Category(2, "Graanproduct"),
                new Category(3, "Maïsproduct")
                ];
        }

        public List<Category> GetAll()
        {
            return categories;
        }
        public Category? Get(int id)
        {
            return categories.SingleOrDefault(c => c.Id == id);
        }
        public Category? Get(string name)
        {
            return categories.SingleOrDefault(c => c.Name == name);
        }
    }
}
