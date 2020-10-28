using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeExample.Services;

namespace FacadeExample
{
    public class CityWeatherWriterFacade
    {
        private readonly CityReaderService cityReader;
        private readonly WeatherService weatherService;
        private readonly JsonWriterService jsonWriter;

        public CityWeatherWriterFacade()
        {
            cityReader = new CityReaderService();
            weatherService = new WeatherService();
            jsonWriter = new JsonWriterService();
        }

        public void GetWeatherForSpecifiedCities(string filename)
        {
            var cities = cityReader.ReadCitiesFromFile(filename);
            foreach (var city in cities)
            {
                var jsonData = weatherService.GetWeatherForCity(city);
                jsonWriter.WriteCityData(city, jsonData);
            }
        }
    }
}
