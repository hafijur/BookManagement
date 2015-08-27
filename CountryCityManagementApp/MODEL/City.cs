using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityManagementApp.MODEL
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string AboutCity { get; set; }
        public double NoOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }

        public City(string cityName, string aboutCity, double noOfDwellers, string location, string weather)
        {
            
        }

        public City()
        {
            
        }
    }

}