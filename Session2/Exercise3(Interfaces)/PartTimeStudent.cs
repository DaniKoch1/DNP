using System;

public class PartTimeStudent : PartTimeEmployee, IStudent
{
    int year;
    public PartTimeStudent(string name, double hourlyWage, int hoursPerMonth, int year) : base(name, hourlyWage, hoursPerMonth) => Register(year);
    public void Register(int year) => this.year = year;
}