using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Dani=new PartTimeEmployee("Dani", 325, 45);
            Employee Domi=new FullTimeEmployee("Domi", 34562);
            Employee Reme=new PartTimeEmployee("Reme", 267, 55);

            Company theBestCompany=new Company();
            theBestCompany.EmployNewEmployee(Dani);
            theBestCompany.EmployNewEmployee(Domi);
            theBestCompany.EmployNewEmployee(Reme);

            System.Console.WriteLine(Dani.GetMonthSalary());
            System.Console.WriteLine(Domi.GetMonthSalary());
            System.Console.WriteLine(Reme.GetMonthSalary());
            System.Console.WriteLine(theBestCompany.GetMonthlySalaryTotal());
        }
    }
}
