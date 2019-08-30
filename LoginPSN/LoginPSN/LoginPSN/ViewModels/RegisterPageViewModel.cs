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
                var w = User.ConfirmPassword;
                //Validacion de que campos no estan vacios
                if (StringValidationHelper.ValidateField(x, y, z, w))
                {
                    DisplayError = "Please complete all the fields to register";
                }
                //Valida que el email introducido es valido
                else if (StringValidationHelper.ValidateEmail(y))
                {
                    await App.Current.MainPage.Navigation.PushAsync(new HomePage());
                }
                //Valida que las contrasenas sean la misma 
                else if (StringValidationHelper.ValidatePassword(z,w))
                {
                    DisplayError = "Please check your password, they are not matching!";
                }
                //Mensaje de error si la informacion no es valida
                else
                {
                    DisplayError = "Please enter valid information";
                }
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
