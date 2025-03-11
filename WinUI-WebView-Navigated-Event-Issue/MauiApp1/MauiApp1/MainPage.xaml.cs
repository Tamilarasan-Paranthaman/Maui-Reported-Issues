using System.Diagnostics;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void webView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            NavigatedLabel.Text = "Navigated event : Called";
        }

        private void webView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            e.Cancel = true;
            NavigatingLabel.Text = "Navigating event : Called";
        }
    }
}
