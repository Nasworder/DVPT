using Newtonsoft.Json;

namespace WeatherAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            string apiKey = "ee42480306d1ac649547e7385533d70d";

            string city = "Marseille";

            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();

                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseContent);

                float tempCelsius = ConvertKelvinToCelsius(weatherData.Main.Temp);

                Console.WriteLine($"Temperature: {tempCelsius}°C");
                Console.WriteLine($"Humidity: {weatherData.Main.Humidity}%");
                Console.WriteLine($"Weather: {weatherData.Weather[0].Main}");
            }
            else
            {
                Console.WriteLine($"Failed to retrieve weather data. Status code: {response.StatusCode}");
            }
        }

        public class WeatherData
        {
            public WeatherMain Main { get; set; }
            public Weather[] Weather { get; set; }
        }

        public class WeatherMain
        {
            public float Temp { get; set; }
            public int Humidity { get; set; }
        }

        public class Weather
        {
            public string Main { get; set; }
        }

        private static float ConvertKelvinToCelsius(float tempKelvin)
        {
            return tempKelvin - 273.15f;
        }
    }
}
