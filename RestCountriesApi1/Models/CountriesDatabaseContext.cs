using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestCountriesApi1.Models
{
    public class CountriesDatabaseContext: DbContext
    {
        public CountriesDatabaseContext(DbContextOptions<CountriesDatabaseContext> options) : base (options)
        {

        }
        public DbSet<Countries> Countries { get; set; }
    }
}
