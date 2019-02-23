using System;
using System.Collections.Generic;

public class Company{
    private List<Employee> employeers=new List<Employee>();
    public double GetMonthlySalaryTotal(){
        double sum=0;
        foreach(Employee e in employeers)
            sum+=e.GetMonthSalary();
        return sum;
    }
    public void EmployNewEmployee(Employee newEmployee){
        employeers.Add(newEmployee);
    }
}