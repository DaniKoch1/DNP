using System;

public class PartTimeEmployee :Employee{
    private double hourlyWage;
    private int hoursPerMonth;

    public PartTimeEmployee(string name, double hourlyWage, int hoursPerMonth):base(name){
        this.hourlyWage=hourlyWage;
        this.hoursPerMonth=hoursPerMonth;
    }
    public override double GetMonthSalary(){
        return hourlyWage*hoursPerMonth;
    }
}