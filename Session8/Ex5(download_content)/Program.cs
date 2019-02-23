using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Ex5_download_content_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s=GetData().GetAwaiter().GetResult();
            System.Console.WriteLine(s);

        }
        static async Task<string> GetData()
        {
            var client = new HttpClient();
            System.Console.WriteLine("Fetching data...");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var str=await client.GetStringAsync("https://www.via.dk/");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return str+"\n\n"+"Time of execution: "+elapsedMs+"msec";
        }
    }
}
