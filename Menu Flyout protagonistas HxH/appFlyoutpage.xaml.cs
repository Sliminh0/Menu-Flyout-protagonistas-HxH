namespace Menu_Flyout_protagonistas_HxH;

public partial class appFlyoutpage : FlyoutPage
{
	public appFlyoutpage()
	{
		InitializeComponent();

		Detail = new NavigationPage(new MainPage());
	}

	private void GonClicked (object? sender, EventArgs e)
	{
		Detail = new NavigationPage(new Gon());
        IsPresented = false;
	}

    private void KilluaClicked(object? sender, EventArgs e)
    {
        Detail = new NavigationPage(new Killua());
        IsPresented = false;
    }

    private void KurapikaClicked(object? sender, EventArgs e)
    {
        Detail = new NavigationPage(new Kurapika());
        IsPresented = false;
    }

    private void LeorioClicked(object? sender, EventArgs e)
    {
        Detail = new NavigationPage(new Leorio());
        IsPresented = false;
    }

    private void MenuClicked(object? sender, EventArgs e)
    {
        Detail = new NavigationPage(new MainPage());
        IsPresented = false;
    }

}