using System;

namespace Exercise1_overwrite_
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Dani=new Student();
            Student Reme=new DNPstudent();
            DNPstudent Gosia=new DNPstudent();
            Student Ola=Gosia;
            Dani.Hi();
            Reme.Hi();
            Ola.Hi();
        }
    }
}
