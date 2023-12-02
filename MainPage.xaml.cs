namespace MauiAppbackbuttonproblem
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        bool _firstTime = true;

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (_firstTime)
            {
                _firstTime = false;
                await Shell.Current.GoToAsync(nameof(SetupPage), new Dictionary<string, object>
                        {
                            { "isinizializzazione", true }
                        });
            }
        }
        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            await Shell.Current.GoToAsync(nameof(SetupPage), new Dictionary<string, object>
                        {
                            { "isinizializzazione", true }
                        });

        }
    }

}
