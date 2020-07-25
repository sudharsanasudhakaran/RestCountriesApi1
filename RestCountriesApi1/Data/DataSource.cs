using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestCountriesApi1.Models;

namespace RestCountriesApi1.Data
{
    public class DataSource
    {
        public CountriesDatabaseContext _db;

        public DataSource(CountriesDatabaseContext context)
        {
            _db = context;
        }

        public List<Countries> countries()
        {
            return _db.Countries.ToList();
        }
        public List<Countries> CountriesByContinent(String ContinentName)
        {
            //return _db.Countries.Where(a => a.CountryCode == countrycode).ToList();
            return _db.Countries.Where(a => a.ContinentName.Equals(ContinentName)).ToList();
        }
        public List<Countries> CountryByCode (String CountryCode)
        {
            return _db.Countries.Where(b => b.CountryCode.Equals(CountryCode)).ToList();
        }
        public List<Countries> CountryBycapital(String Capital)
        {
            return _db.Countries.Where(c => c.Capital.Equals(Capital)).ToList();
        }


    }
}
