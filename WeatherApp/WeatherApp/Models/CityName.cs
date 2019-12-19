using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Models
{
    class CityName
    {
        [PrimaryKey, AutoIncrement]
        public int CityID { get; set; }
        public string NameofCity { get; set; }
    }
}
