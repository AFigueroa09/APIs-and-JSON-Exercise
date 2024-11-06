using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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

            try
            {
                var weatherResponse = _client.GetStringAsync(url).Result;
                var name = JObject.Parse(weatherResponse).GetValue("name").ToString();

                var currentWeather = JObject.Parse(weatherResponse).GetValue("main").ToString();
                var temp = JObject.Parse(currentWeather).GetValue("temp").ToString();

                return $"In {name} it is currently {temp} degreees F.";
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            return "";
        }

    }
}
