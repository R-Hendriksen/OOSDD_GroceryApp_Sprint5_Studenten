using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Core.Models
{
    public partial class Category(int id, string name) : ObservableObject
    {
        public int Id { get; set; } = id;
        [ObservableProperty]
        public string name = name;

    }
}
