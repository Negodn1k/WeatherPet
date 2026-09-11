using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WeatherPet
{
    internal class Wheather
    {
        public class LatLonJson
        {
            public Double lat {  set; get; }
            public Double lon { set; get; }
        }

        public class WeatherForecast
        {

        }

        public void getWeather()
        {
            string apiKey = Environment.GetEnvironmentVariable("WEATHER_API_KEY");

            HttpClient client = new HttpClient();
            LatLonJson jsonObj = JsonSerializer.Deserialize<LatLonJson>(client.GetStringAsync($"http://api.openweathermap.org/geo/1.0/direct?q=Saint Petersburg,RU&appid={apiKey}").Result);

            //https://api.openweathermap.org/data/4.0/onecall/current?lat=59lon=30&appid=951990e2fc10826954f1e3360eccc8ca
            WeatherForecast weather = JsonSerializer.Deserialize<WeatherForecast>(client.GetStringAsync($"https://api.openweathermap.org/data/4.0/onecall/current?lat={jsonObj.lat}" +
                $"&lon={jsonObj.lon}&appid={apiKey}").Result);

        }
    }
}
