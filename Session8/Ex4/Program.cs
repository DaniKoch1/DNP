using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;


namespace Ex4
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
            HttpClient client=new HttpClient();
            System.Console.WriteLine("Fetching data...");
            var serializer = new DataContractJsonSerializer(typeof(List<Repo>));
            var str =await client.GetStreamAsync(" https://jsonplaceholder.typicode.com/users");
            var repositories= serializer.ReadObject( str) as List<Repo>;
            string answer="The list of users: \n";
            foreach (var repo in repositories)
                answer+= repo.name+": "+repo.email+"\n";
            return answer;
        }
    }
}
