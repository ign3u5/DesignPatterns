using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace FacadeExample.Services
{
    public class WeatherService
    {
        public string GetWeatherForCity(string cityName)
        {
            using HttpClient client = new HttpClient();
            var response = client.GetAsync($"http://wttr.in/{cityName}?format=j1").Result;
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
