using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System;
using AppRescontries.Models;

namespace AppRescontries.Services
{
    public class CountryService
    {
        private const string BaseUrl = "https://restcountries.com/v3.1/region/";

        public async Task<List<Country>> GetCountriesByRegionAsync(string region)
        {
            var url = $"{BaseUrl}{region}";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var countries = JsonConvert.DeserializeObject<List<Country>>(json);
                return countries;
            }
            return new List<Country>();
        }
    }

}
