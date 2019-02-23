using System;
using System.Collections.Generic;

namespace Ex9_Lambda_expressions_
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars=new List<Car>();
            Car car1=new Car("blue",20,150);
            Car car2=new Car("red",25,170);
            Car car3=new Car("white",19.5,225);
            cars.AddAll(car1,car2,car3);
            System.Console.WriteLine(cars.FindAll(IsBlue).ToString());
        }


         public static Boolean IsBlue(Car car) => car.color.Equals("blue");


        public static void AddAll<T>(this List<T> list, params T[] items){
            foreach(var item in items){
                list.Add(item);
            }
        }
    }
}
