using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using LoginPSN.Helpers;
using LoginPSN.Models;
using LoginPSN.ViewModels;
using Xamarin.Forms;
using LoginPSN.Views;

namespace LoginPSN.ViewModels
{
    public class RegisterPageViewModel : INotifyPropertyChanged
    {
        //String para mostrar errores
        public string DisplayError { get; set; }
        public User User { get; set; } = new User();
        //Comando de registro
        public ICommand RegisterCommand { get; set; }
        public RegisterPageViewModel()
        {
            RegisterCommand = new Command(async () =>
            {
                var x = User.Name;
                var y = User.Email;
                var z = User.Password;
                //Si email and password estan vacios mensaje de error
                if (string.IsNullOrEmpty(User.Name) || string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Password))
                {
                    DisplayError = "Please complete all the fields to register";
                }
                //Valida que el email introducido es valido
                else if (StringValidationHelper.ValidateEmail(y))
                {
                    await App.Current.MainPage.Navigation.PushAsync(new HomePage());
                }
                //Usuario es bienvenido a pagina de home luego de haber registrado
                else
                {
                    DisplayError = "Please enter valid information";
                }
            });

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
