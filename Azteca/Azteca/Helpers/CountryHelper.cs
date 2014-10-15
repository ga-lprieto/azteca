using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Azteca.Helpers
{
    public class CountryHelper
    {
        public static readonly string[] ImplementedCountries = {"AR" , "CL", "BR" , "CO", "MX" };

        public static bool isCountryImplemented(string locale) {
            if (ImplementedCountries.Contains(locale))
            {
                return true;
            }
            return false;
        }

    }
}