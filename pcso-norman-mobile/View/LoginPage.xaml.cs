using pcso_norman_mobile.VideModel;

namespace pcso_norman_mobile.View;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel loginViewModel)
	{
		InitializeComponent();

		BindingContext = loginViewModel;

	}
}