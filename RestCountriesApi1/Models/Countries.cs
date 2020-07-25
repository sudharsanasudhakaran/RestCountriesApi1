using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCountriesApi1.Models
{
    public class Countries
    {   

        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string Capital { get; set; }
        public string ContinentName { get; set; }
    }
}
