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
        public string DisplayError { get; set; }
        public User User { get; set; } = new User();
        public ICommand RegisterCommand { get; set; }
        public RegisterPageViewModel()
        {
            RegisterCommand = new Command(async () =>
            {
                var x = User.Name;
                var y = User.Email;
                var z = User.Password;

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

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
