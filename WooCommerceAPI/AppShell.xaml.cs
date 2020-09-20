using System;
using System.Collections.Generic;
using WooCommerceAPI.ViewModels;
using WooCommerceAPI.Views;
using Xamarin.Forms;

namespace WooCommerceAPI
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
