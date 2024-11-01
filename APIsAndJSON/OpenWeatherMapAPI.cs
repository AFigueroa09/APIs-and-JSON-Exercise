using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        private HttpClient _client;
        private string _apiKey;

        public OpenWeatherMapAPI(HttpClient client, string apiKey)
        {
            _client = client;
            _apiKey = apiKey;
            
        }

        public string GetWeather(string lat, string lon)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={_apiKey}";
            var weatherResponse = _client.GetStringAsync(url).Result;
            var currentWeather = JArray.Parse(weatherResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            return currentWeather;
        }

    }
}
