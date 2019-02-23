using System;

namespace Ex8_Delegates_
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> notifier=Talking.SayHello;
            notifier+=Talking.SayGoodbye;
            notifier("Dani");
        }
    }
}
