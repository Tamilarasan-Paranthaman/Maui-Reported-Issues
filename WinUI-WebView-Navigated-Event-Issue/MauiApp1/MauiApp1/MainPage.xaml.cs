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
            Debug.WriteLine("The Navigated event was called");
        }

        private void webView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            e.Cancel = true;
            Debug.WriteLine("The Navigating event was called ");
        }
    }
}