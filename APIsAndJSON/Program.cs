namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            RonVSKanyeAPI api = new RonVSKanyeAPI(client);
            OpenWeatherMapAPI weatherApi = new OpenWeatherMapAPI(client, "d8bab89e5ff75df864e607006905b22d");

            Console.WriteLine("----------------");
            Console.WriteLine("Ron Swanson Quotes");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(api.GetRonQuote());
            }

            //Console.WriteLine("----------------");
            //Console.WriteLine("Kanye Quotes");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(api.GetKanyeQuote());  
            //}

            Console.WriteLine("----------------");
            Console.WriteLine("Current weather in Round Rock");
            Console.WriteLine(weatherApi.GetWeather("31.37","10.99"));
        }
    }
}
