using CommunityToolkit.Mvvm.Input;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;

namespace Grocery.App.ViewModels
{
    public partial class CategoriesViewModel : BaseViewModel
    {
        private readonly ICategoryService _categoryService;
        public ObservableCollection<Category> Categories { get; set; }

        public CategoriesViewModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            Categories = [];
            foreach (Category c in _categoryService.GetAll()) Categories.Add(c);
        }

        [RelayCommand]
        public async Task SelectCategory(Category category)
        {
            Dictionary<string, object> paramater = new() { { nameof(Category), category } };
            await Shell.Current.GoToAsync($"{nameof(Views.ProductCategoriesView)}?Titel={category.Name}", true, paramater);
        }


        public override void OnAppearing()
        {
            base.OnAppearing();
            Categories = new(_categoryService.GetAll());
        }

        public override void OnDisappearing()
        {
            base.OnDisappearing();
            Categories.Clear();
        }
    }
}
