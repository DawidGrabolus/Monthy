namespace Monthy.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
        startButton.Clicked += StartButton_Clicked;
	}

    private async void StartButton_Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new LessonPage());
    }
}