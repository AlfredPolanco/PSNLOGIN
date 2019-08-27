using System;
using System.Collections.Generic;
using Xamarin.Forms;
using LoginPSN.ViewModels;

namespace LoginPSN.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
        }
    }
}