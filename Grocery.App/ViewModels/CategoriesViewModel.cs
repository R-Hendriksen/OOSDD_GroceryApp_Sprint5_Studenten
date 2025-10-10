using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;

namespace Grocery.App.ViewModels
{
    public class CategoriesViewModel : BaseViewModel
    {
        private readonly IProductService _productService;

        public CategoriesViewModel(IProductService productService)
        {
            
        }
    }
}
