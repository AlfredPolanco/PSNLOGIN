using System;
using System.Collections.Generic;
using System.Text;
using LoginPSN.Models;
using Xamarin.Forms;
using System.Windows.Input;
using System.ComponentModel;
using LoginPSN.Helpers;
using LoginPSN.ViewModels;
using LoginPSN.Views;

namespace LoginPSN.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        public string DisplayError { get; set; }
        public User User { get; set; } = new User();
        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        public ICommand GoSony { get; set; }
        public LoginPageViewModel()
        {
            LoginCommand = new Command(async() =>
            {
                var x = User.Email;
                var y = User.Password;
                //Valida que el email y password no esten vacios
                if (string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Password))
                {
                    //Result = Application.Current.Properties["Resul"].ToString();
                    //await Application.Current.MainPage.DisplayAlert("Alert", "Please enter email address and password", "Ok");
                }
                //Valida que el email introducido es valido
                //else if ()
                //{

                //}

                //Usuario es bienvido al presionar el boton de LogIn 
                else
                {
                    await App.Current.MainPage.Navigation.PushAsync(new HomePage());
                }
            });

            RegisterCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());

            });

            GoSony = new Command(async () =>
            {

                //await Device.OpenUri(new Uri("https://id.sonyentertainmentnetwork.com/id/reset_password/?request_locale=en_US#/reset_password/change?entry=%2Freset_password"));

            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string DisplayError)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(DisplayError));
        }
    }
}
