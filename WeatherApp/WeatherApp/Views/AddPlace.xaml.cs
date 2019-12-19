using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WeatherApp.Models;

namespace WeatherApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPlace : ContentPage
    {
        public string namecity = "";
        public AddPlace()
        {
            InitializeComponent();
        }
        private void AddNameOfCity_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Location Changed!", "OK");
            namecity = NameOfCity.Text;
            NameOfCity.Text = "";
            Navigation.PushAsync(new CurrentWeatherPage(namecity));
        }
    }
}