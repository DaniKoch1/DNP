using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s=AccessTheWebAsync().GetAwaiter().GetResult();
            System.Console.WriteLine(s);
        }

        static async Task<string> AccessTheWebAsync()
        {
            HttpClient client= new HttpClient();
            Task<string> getStringTask= client.GetStringAsync("https://via.dk");
            //do stuff without waiting for the get string
            string urlContents = await getStringTask;
            return urlContents;
        }
    }
}
