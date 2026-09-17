namespace Menu_Flyout_protagonistas_HxH;

public partial class appFlyoutpage : ContentPage
{
	public appFlyoutpage()
	{
		InitializeComponent();

		Detail = new NavigationPage(new MainPage());
	}
}