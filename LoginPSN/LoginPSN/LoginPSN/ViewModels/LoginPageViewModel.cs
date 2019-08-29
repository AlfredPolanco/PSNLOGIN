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
        //String para mostrar errores
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
                    DisplayError = "Please enter email address and password";
                }
                //Valida que el email introducido es valido y si es valido nos lleva a HommePage
                else if (StringValidationHelper.ValidateEmail(x))
                {

                    await App.Current.MainPage.Navigation.PushAsync(new HomePage());
                }
                else
                {
                    //Mensaje de invalid credenctials
                    DisplayError = "Please enter valid email address and password";
                }
            });
            //Al ser presionado te lleva a la pagina de register
            RegisterCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());

            });
            //Al ser presionado te lleva hacia el navegador para un password reset
            GoSony = new Command(() =>
            {

               Device.OpenUri(new Uri("https://id.sonyentertainmentnetwork.com/id/reset_password/?request_locale=en_US#/reset_password/change?entry=%2Freset_password"));

            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
