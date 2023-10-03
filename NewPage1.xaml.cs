namespace MauiApp_4_Kosichkin;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }
    // для окна с кнопкой 
   

   

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (History.IsChecked == true)
        {
            Entry.Text = "1,2 Course";
        }

        if (Cultural_Studies.IsChecked == true)
        {
            Entry.Text = "3,4 Course";
        }

        if (Philosophy.IsChecked == true)
        {
            Entry.Text = "4,3 Course";
        }

        if (Foreign_languagery.IsChecked == true)
        {
            Entry.Text = "1,2,3,4 Course";
        }
    }
}