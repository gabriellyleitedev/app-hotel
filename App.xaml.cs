using Microsoft.Extensions.DependencyInjection;

namespace AppHotel;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage());
	}

}