using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.App.ViewModels
{
    public class ProductCategoriesViewModel : BaseViewModel
    {
        private readonly IProductCategoryService _productCategoryService;
        public ObservableCollection<ProductCategory> ProductCategories { get; set; }

        public ProductCategoriesViewModel(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
            ProductCategories = [];
            foreach (ProductCategory pc in _productCategoryService.GetAll()) ProductCategories.Add(pc);
        }
    }
}
