using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherPet
{
    internal class WeatherResponseJson
    {
        [JsonPropertyName("coord")]
        public Coord coord { get; set; }

        [JsonPropertyName("weather")]
        public List<WeatherCondition> weather { get; set; }

        [JsonPropertyName("base")]
        public string base_ { get; set; }

        [JsonPropertyName("main")]
        public MainData main { get; set; }

        [JsonPropertyName("visibility")]
        public int visibility { get; set; }

        [JsonPropertyName("wind")]
        public WindData wind { get; set; }

        [JsonPropertyName("clouds")]
        public CloudsData clouds { get; set; }

        [JsonPropertyName("dt")]
        public long dt { get; set; }

        [JsonPropertyName("sys")]
        public SysData sys { get; set; }

        [JsonPropertyName("timezone")]
        public int timezone { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("cod")]
        public int cod { get; set; }
    }

    public class Coord
    {
        [JsonPropertyName("lon")]
        public double lon { get; set; }

        [JsonPropertyName("lat")]
        public double lat { get; set; }
    }

    public class WeatherCondition
    {
        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("main")]
        public string main { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("icon")]
        public string icon { get; set; }
    }

    public class MainData
    {
        [JsonPropertyName("temp")]
        public double temp { get; set; }

        [JsonPropertyName("feels_like")]
        public double feels_like { get; set; }

        [JsonPropertyName("temp_min")]
        public double temp_min { get; set; }

        [JsonPropertyName("temp_max")]
        public double temp_max { get; set; }

        [JsonPropertyName("pressure")]
        public int pressure { get; set; }

        [JsonPropertyName("humidity")]
        public int humidity { get; set; }

        [JsonPropertyName("sea_level")]
        public int sea_level { get; set; }

        [JsonPropertyName("grnd_level")]
        public int grnd_level { get; set; }
    }

    public class WindData
    {
        [JsonPropertyName("speed")]
        public double speed { get; set; }

        [JsonPropertyName("deg")]
        public int deg { get; set; }
    }

    public class CloudsData
    {
        [JsonPropertyName("all")]
        public int all { get; set; }
    }

    public class SysData
    {
        [JsonPropertyName("type")]
        public int type { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("country")]
        public string country { get; set; }

        [JsonPropertyName("sunrise")]
        public long sunrise { get; set; }

        [JsonPropertyName("sunset")]
        public long sunset { get; set; }
    }
}
