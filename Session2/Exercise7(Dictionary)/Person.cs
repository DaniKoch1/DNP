using System;

namespace Exercise7_Dictionary_{
    class Person{
        public string name {get; set;}
        public int age {get; set;}
         public double iq {get; set;}

        public Person(string name, int age, double iq){
            this.name=name;
            this.age=age;
            this.iq=iq;
        }
    }
}