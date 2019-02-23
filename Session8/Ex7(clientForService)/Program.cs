using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Ex7_clientForService_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s=GetData().GetAwaiter().GetResult();
            string[] c=s.Split(">");
            for(int i=0;i<c.Length;i++)
            {
                //System.Console.WriteLine(c[i]);
                if(c[i].StartsWith("<p"))
                {
                    while(!(c[i].StartsWith("</p")))
                    {
                        System.Console.WriteLine(c[i]);
                        i++;
                    }
                }
            }

        }
        static async Task<string> GetData()
        {
            var client = new HttpClient();
            System.Console.WriteLine("Fetching data...");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var str=await client.GetStringAsync("http://ente.org.pl/");
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return str+"\n\n"+"Time of execution: "+elapsedMs+"msec";
        }
    }
}
