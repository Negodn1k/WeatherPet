using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherPet
{
    internal class Weather
    {
        public class CityJson
        {
            [JsonPropertyName("name")]
            public string name { get; set; }

            [JsonPropertyName("local_names")]
            public Dictionary<string, string> local_names { get; set; }

            [JsonPropertyName("lat")]
            public double lat { get; set; }

            [JsonPropertyName("lon")]
            public double lon { get; set; }

            [JsonPropertyName("country")]
            public string country { get; set; }

            [JsonPropertyName("state")]
            public string state { get; set; }
    }

        //public class WeatherForecastJson
        //{
        //    public String name {  get; set; }
        //    public String description { set; get; }
        //    public Double temp { set; get; }
        //    public Double feels_like { set; get; }
        //    public Double speed { set; get; }
        //}

        public string getWeather()
        {
            //TD Здесь вызов бд?

            HttpClient client = new HttpClient();
            List<CityJson> jsonArr = JsonSerializer.Deserialize<List<CityJson>>(client.GetStringAsync("http://api.openweathermap.org/geo/1.0/direct?q=Saint%20Petersburg,RU&appid=951990e2fc10826954f1e3360eccc8ca").Result);

            CityJson jsonObj = jsonArr.FirstOrDefault();
            //https://api.openweathermap.org/data/2.5/weather?q=Saint%20Petersburg&appid=951990e2fc10826954f1e3360eccc8ca&units=metric&lang=ru
            WeatherResponseJson weather = JsonSerializer.Deserialize<WeatherResponseJson>(client.GetStringAsync($"https://api.openweathermap.org/data/2.5/weather?q={jsonObj.name}&appid=951990e2fc10826954f1e3360eccc8ca&units=metric&lang=ru").Result);

            return GetWeatherString(weather);
        }

        private string GetWeatherString(WeatherResponseJson rawJson)
        {
            return $"{rawJson.name}\n" +
                $"Осадки: {rawJson.weather.FirstOrDefault().description}\n" +
                $"Температура: {rawJson.main.temp}   Ощущается как: {rawJson.main.feels_like}\n" +
                $"Скорость ветра: {rawJson.wind.speed}";
        }
    }
}
