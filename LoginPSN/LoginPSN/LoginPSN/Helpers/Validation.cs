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
            var eamilPattern =
                 @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
             + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
			   [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
			   [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
             + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

            if (Regex.IsMatch(e, eamilPattern))
            {
                return true;
            }

            // correo invalido
            return false;


        }

    }
}
