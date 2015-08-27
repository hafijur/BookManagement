using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityManagementApp.MODEL
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string AboutCountry { get; set; }

        public Country(string countryName, string aboutCountry)
        {
            CountryName = countryName;
            AboutCountry = aboutCountry;
        }

        public Country()
        {
            
        }

    }
}