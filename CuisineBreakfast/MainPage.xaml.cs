using CuisineBreakfast.ViewModels;

namespace CuisineBreakfast;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MyBreakfastsViewModel();
	}


}

