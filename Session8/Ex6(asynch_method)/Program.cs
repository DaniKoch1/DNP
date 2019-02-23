using System;
using System.Threading.Tasks;

namespace Ex6_asynch_method_
{
    class Program
    {
        static void Main(string[] args)
        {
            Program whatever=new Program();
            whatever.AMethod().GetAwaiter().GetResult();
        }
        public async Task AMethod(){
            System.Console.WriteLine("Hola!");
            await Task.Delay(3000);
            System.Console.WriteLine("Hello!");
        }
        
    }
}
