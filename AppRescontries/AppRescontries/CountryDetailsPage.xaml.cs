using AppRescontries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRescontries
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountryDetailsPage : ContentPage
    {
        public CountryDetailsPage(Country country)
        {
            InitializeComponent();
            BindingContext = new CountryDetailsViewModel(country);
        }
    }

    public class CountryDetailsViewModel
    {
        public Country Country { get; }

        public CountryDetailsViewModel(Country country)
        {
            Country = country;
        }

       
        public string CapitalString => string.Join(", ", Country.Capital);

        public string LanguagesString => string.Join(", ", Country.Languages.Values);

        public string CurrenciesString => string.Join(", ", Country.Currencies.Values.Select(c => c.Name));

        public string AreaString => $"{Country.Area:N0} km²";

        public string PopulationString => $"{Country.Population:N0}";
    }


}