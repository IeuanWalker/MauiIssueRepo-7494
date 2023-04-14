using App.ViewModels;

namespace App.Pages;

public partial class MainPage : ContentPage
{
	readonly HomeViewModel _vm = new();
	public MainPage()
	{
		InitializeComponent();

		BindingContext = _vm;
	}

	void PreviousDateBtn_Clicked(object sender, EventArgs e)
	{
		try
		{
			LogCarousel.Position = LogCarousel.Position--;
		}
		catch (IndexOutOfRangeException)
		{
			// Ignore, if users spams the button its possible for them to trigger it before its made invisable
		}
    }

	void NextDateBtn_Clicked(object sender, EventArgs e)
	{
		try
		{
			LogCarousel.Position = LogCarousel.Position++;
		}
		catch (IndexOutOfRangeException)
		{
			// Ignore, if users spams the button its possible for them to trigger it before its made invisable
		}
	}

	void LogCarousel_PositionChanged(object sender, PositionChangedEventArgs e)
	{
		previousDateBtn.IsVisible = e.CurrentPosition != 0;

		nextDateBtn.IsVisible = e.CurrentPosition != _vm.Logs.Count - 1;
	}
}