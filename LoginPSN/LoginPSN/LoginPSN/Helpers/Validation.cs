using System;
using System.Collections.Generic;
using System.Text;
using LoginPSN.ViewModels;
using LoginPSN.Views;
using LoginPSN.Models;
using System.Text.RegularExpressions;

namespace LoginPSN.Helpers
{
    public class Validation
    {
        public bool ValidateEmail(string e)
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
