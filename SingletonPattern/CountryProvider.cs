using SingletonPattern.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class CountryProvider
    {
        //Obyekti daimi saxlamaq ucun buna set elemek lazimdi
        private static CountryProvider instance { get; set; } = null;
        public static CountryProvider Instance => instance ?? (instance = new CountryProvider());
        private new List<Country> Countries { get; set; }


        //BU clasdan obyekt yaradilmasin istiyirikse constructoru private ede bilerik

        private CountryProvider()
        {
            Task.Delay(2000).GetAwaiter().GetResult();

            Countries = new List<Country>()
                    {
                        new Country(){Name="Azerbaijan"},
                        new Country(){Name="Turkish"}
                    };
        }

        public async Task<List<Country>> GetCountries() => Countries;
    }
}
