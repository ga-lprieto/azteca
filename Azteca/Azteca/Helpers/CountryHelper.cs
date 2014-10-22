using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Azteca.Helpers
{
    public class CountryHelper
    {
        public static readonly string[] ImplementedCountries = {"es-AR" , "es-CL", "pt-BR" , "es-CO", "es-MX" };

        public static string getLangForCountry(string countryCode)
        {
            if (countryCode.Equals("ALL"))
            {
                return "en";
            }
            string Lang = string.Empty;
            foreach (string s in ImplementedCountries)
            {
                if(s.Split('-')[1].Equals(countryCode))
                {
                    Lang = s.Split('-')[0];
                }
            }

            return Lang;
        }


        public static IEnumerable<string> getAddress(string countryCode)
        {
            List<string> l ;

            if ( ! countryCode.Equals("ALL"))
            {
                string add = WebConfigurationManager.AppSettings["HC_"+ countryCode];
                l = new List<string>();
                l.Add(add);

            }
            else 
            {
                string add = WebConfigurationManager.AppSettings["HC_ALL"];
                l = new List<string>(add.Split(';'));
            }

            return l;
        }

    }
}