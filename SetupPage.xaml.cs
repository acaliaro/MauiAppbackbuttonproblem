namespace MauiAppbackbuttonproblem;

public partial class SetupPage : ContentPage
{
	public SetupPage(SetupViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}