using System;
using System.Collections.Generic;
using System.Text;
using LoginPSN.ViewModels;
using LoginPSN.Views;
using LoginPSN.Models;
using System.Text.RegularExpressions;

namespace LoginPSN.Helpers
{
    public static class StringValidationHelper
    {
        //Valida que ambas contrasenas sean similares, de no serlo retorna falso
        public static bool ValidatePassword(string passw1, string passw2)
        {
            if(passw1 == passw2)
            {
                return true;
            }
            return false;
        }
        //Valida que los campos no esten vacios
        public static bool ValidateField(string x, string y, string z, string w)
        {
            if (string.IsNullOrEmpty(x) || string.IsNullOrEmpty(y) || string.IsNullOrEmpty(z) || string.IsNullOrEmpty(w))
            {
                return true;
            }
            return false;
        }
        //Valida que el correo sea valido
        public static bool ValidateEmail(string e)
        {
            //Patron del email
            var eamilPattern =
                 @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
             + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
			   [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
			   [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
             + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";
            //Si el correo es valido returna verdadero
            if (Regex.IsMatch(e, eamilPattern))
            {
                return true;
            }
            //Sino retorna falso
            return false;
        }

    }
}
