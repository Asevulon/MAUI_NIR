namespace MAUI_NIR;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		CounterBtn.Text = $"{count} нажатий!";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void OnResetClicked(object sender, EventArgs e)
	{
		count = 0;
		CounterBtn.Text = "Нажми меня!";
        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

