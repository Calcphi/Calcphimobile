using CalcphiMobile.ViewModels;
using CalcphiMobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Essentials;


namespace CalcphiMobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }
        private async void About_us(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://calcphi.netlify.app/");

        }
    }
}
