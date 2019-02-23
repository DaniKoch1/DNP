using System;

public class FullTimeEmployee: Employee{
    private double monthlySalary;

    public FullTimeEmployee(string name, double salary) :base(name){
        monthlySalary=salary;
    }
    public override double GetMonthSalary(){
        return monthlySalary;
    }
}