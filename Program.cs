using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudsekDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // string secretUrl = "http://15.206.47.5:9090/cloudsek.php";
            string secretUrl = "https://app.SkyHighBank.com/";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    Console.WriteLine("Sending GET request to the secret URL...");
                    HttpResponseMessage response = await client.GetAsync(secretUrl);
                    string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine("Response received:");
                    Console.WriteLine(responseBody);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("Request error:");
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
