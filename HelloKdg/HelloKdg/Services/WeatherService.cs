using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HelloKdg.Model;
using Newtonsoft.Json;

namespace HelloKdg.Services
{
    internal interface IWeatherService
    {
        Task<Weather> GetWeatherResultFor(double latitude, double longitude);
    }

    internal class WeatherService : IWeatherService
    {
        public async Task<Weather> GetWeatherResultFor(double latitude, double longitude)
        {
            HttpClient client = new HttpClient();
            var jsonString = await client.GetStringAsync($"http://api.openweathermap.org/data/2.5/weather?lat={latitude}&lon={longitude}&units=metric&appid=ac537c76e38a89528592bd2921da207c");

            return JsonConvert.DeserializeObject<Weather>(jsonString);
        }

    }
}
