using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestCountriesApi1.Data;
using RestCountriesApi1.Models;

namespace RestCountriesApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private DataSource dataConn;

        public CountriesController(CountriesDatabaseContext context)
        {
            dataConn = new DataSource(context);
        }
        [HttpGet("Countries")]
        public List<Countries> countries()
        {
            return dataConn.countries();
        }
        [HttpGet("CountryCode/{countrycode}")]
        public List<Countries> code(string countrycode)
        {
            return dataConn.CountryByCode(countrycode);
        }
        [HttpGet("Capital/{capital}")]
        public List<Countries> capital (string capital)
        {
            return dataConn.CountryBycapital(capital);
        }
        [HttpGet("Continent/{continent}")]
        public List<Countries> continents(string continent)
        {
            return dataConn.CountriesByContinent(continent);
        }

    }
}
