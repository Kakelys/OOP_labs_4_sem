using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Lab_2
{
    internal class MyUDKAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is string ydk)
            {
                Regex regex = new Regex("^(([0-9]{3})|([0-9]{3}.[0-9]{1})|([0-9]{2}.[0-9]{1})|([0-9]{3}.[0-9]{3}))$");

                if (regex.IsMatch(ydk))
                    return true;
                else
                    ErrorMessage = "Wrong UDK";

            }
            return false;
        }
    }
}
