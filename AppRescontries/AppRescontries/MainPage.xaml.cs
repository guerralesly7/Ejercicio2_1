// MainPage.xaml.cs
using AppRescontries.Models;
using AppRescontries.Services;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AppRescontries
{
    public partial class MainPage : ContentPage
    {

        private CountryService _restCountriesService = new CountryService();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
      
        }
        private async void OnRegionSelected(object sender, EventArgs e)
        {
            var region = RegionPicker.SelectedItem.ToString();
            var countries = await _restCountriesService.GetCountriesByRegionAsync(region);
            CountriesListView.ItemsSource = countries;
        }

        private async void OnCountrySelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Country country)
            {
                await Navigation.PushAsync(new CountryDetailsPage(country));
                CountriesListView.SelectedItem = null;
            }
        }


    }
}
