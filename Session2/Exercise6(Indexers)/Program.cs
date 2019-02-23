using System;

namespace Exercise6_Indexers_
{
    class Program
    {
        static void Main(string[] args)
        {
            Schedule mySchedule= new Schedule();
            /*
            DateTime monday=new DateTime(2018, 09, 10);
            DateTime tuesday=new DateTime(2018, 09, 11);
            DateTime wednesday=new DateTime(2018, 09, 12);
            DateTime thursday=new DateTime(2018, 09, 13);
            DateTime friday=new DateTime(2018, 09, 14);
            mySchedule[monday]="CAO, DNP";
            mySchedule[tuesday]="SDJ";
            mySchedule[wednesday]="NES, BCP";
            mySchedule[thursday]="SEP";
            mySchedule[friday]="BCP";

            System.Console.WriteLine(mySchedule[friday]);
            System.Console.WriteLine(mySchedule[tuesday]);
            System.Console.WriteLine(mySchedule[wednesday]);
            System.Console.WriteLine(mySchedule[thursday]);
            System.Console.WriteLine(mySchedule[monday]);
            */

            string monday="2018, 09, 10";
            string tuesday="2018, 09, 11";
            string wednesday="2018, 09, 12";
            string thursday="2018, 09, 13";
            string friday="2018, 09, 14";
           
            mySchedule[monday]="CAO, DNP";
            mySchedule[tuesday]="SDJ";
            mySchedule[wednesday]="NES, BCP";
            mySchedule[thursday]="SEP";
            mySchedule[friday]="BCP";

            System.Console.WriteLine(mySchedule[friday]);
            System.Console.WriteLine(mySchedule[tuesday]);
            System.Console.WriteLine(mySchedule[wednesday]);
            System.Console.WriteLine(mySchedule[thursday]);
            System.Console.WriteLine(mySchedule[monday]);
        }
    }
}
