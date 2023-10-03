namespace MauiApp_4_Kosichkin;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void History_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if ((sender as RadioButton).IsChecked)
        {
            DisplayAlert("Заголовок", "1,2 курс", "ОК");
        }
    }

    private void Cultural_Studies_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if ((sender as RadioButton).IsChecked)
        {
            DisplayAlert("Заголовок", "3,4 курс", "ОК");
        }
    }

    private void Philosophy_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if ((sender as RadioButton).IsChecked)
        {
            DisplayAlert("Заголовок", "1,2,3,4 курс", "ОК");
        }
    }

    private void Foreign_languagery_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if ((sender as RadioButton).IsChecked)
        {
            DisplayAlert("Заголовок", "4,3 курс", "ОК");
        }
    }
}

