using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CuisineBreakfast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuisineBreakfast.ViewModels;
public partial class MyBreakfastsViewModel : ObservableObject
{
    [ObservableProperty]
    List<Breakfast> breakfasts;

    [ObservableProperty]
    bool isRefreshing;

    public MyBreakfastsViewModel()
    {
        LoadBreakfastsAsync();
    }

    [RelayCommand]
    public async Task LoadBreakfastsAsync()
    {
        try
        {
            await Task.Delay(2000);
            Breakfasts = new()
            {
                new Breakfast(
                    Name: "Sadza nemuboora",
                    Description: "Vegan everything! Join us for a healthy breakfast full of vegan dishes and Cookies 🌿😋",
                    StartDateTime: DateTime.UtcNow.AddDays(1),
                    EndDateTime: DateTime.UtcNow.AddDays(1).AddHours(2),
                    Image: new Uri("https://www.freeimages.com/photo/roast-vegetables-1641837"),
                    Savory: new List<string> {"Oatmeal", "Avocado Toast", "Omlet", "Salad"},
                    Sweet: new List<string> {"Cookie"}),
                new Breakfast(
                    Name: "Breakfast @ Glennis'",
                    Description: "Hi, Im Glennis 👋 I'll be your chef on Sunday 💪",
                    StartDateTime: DateTime.UtcNow.AddDays(1),
                    EndDateTime: DateTime.UtcNow.AddDays(1).AddHours(2),
                    Image: new Uri("https://www.freeimages.com/photo/roast-vegetables-1641837"),
                    Savory: new List<string> {"Sandwich", "Salad", "Omelet"},
                    Sweet: new List<string> {"Pancake", "Waffle"})
            };
        }
        finally
        {
            IsRefreshing = false;
        }
    }
}