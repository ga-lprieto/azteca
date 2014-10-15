using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Azteca.Helpers
{
    public class CountryHelper
    {
        public static readonly string[] ImplementedCountries = {"es-AR" , "es-CL", "pt-BR" , "es-CO", "es-MX" };

        public static string getLangForCountry(string country)
        {
            string countryCode = getCountryCode(country);
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

        public static string getCountryCode(string country)
        {
            var regions = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(x => new RegionInfo(x.LCID));
            var countryRegion = regions.FirstOrDefault(region => region.EnglishName.Contains(country));
            return countryRegion.Name;
        }
    }
}