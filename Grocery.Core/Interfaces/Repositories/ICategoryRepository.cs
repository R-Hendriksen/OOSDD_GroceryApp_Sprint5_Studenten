using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        public List<Category> GetAll();
        public Category? Get(int id);
        public Category? Get(string name);
    }
}
