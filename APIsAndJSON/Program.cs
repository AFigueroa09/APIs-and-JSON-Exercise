namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            RonVSKanyeAPI api = new RonVSKanyeAPI(client);

            Console.WriteLine("----------------");
            Console.WriteLine("Ron Swanson Quotes");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(api.GetRonQuote());
            }

            Console.WriteLine("----------------");
            Console.WriteLine("Kanye Quotes");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(api.GetKanyeQuote());  
            }
            
        }
    }
}
