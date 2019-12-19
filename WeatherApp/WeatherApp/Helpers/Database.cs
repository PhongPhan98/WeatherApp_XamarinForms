using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Models;
using Xamarin.Forms;
using System.Linq;
using SQLite;

namespace WeatherApp.Helpers
{
    public class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public Database()
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "cityname.db")))
                {
                    connection.CreateTable<CityName>();
                }
            }
            catch
            {
            }
        }
    }
}
