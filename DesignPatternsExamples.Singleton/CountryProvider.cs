using DesignPatternsExamples.Singleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Singleton
{
    public class CountryProvider
    {
        private static CountryProvider instance;
        public static CountryProvider Instance =>instance ??= new CountryProvider();
        private new List<Country> Countries { get; set; }

        private CountryProvider()
        {
            Task.Delay(2000).Wait();

            Countries = new List<Country>()
            {
                new Country() {Name="Türkiye"},
                new Country() {Name="USA" }
            };
        }

        public async Task<List<Country>> GetCountries() => Countries;

    }
}
