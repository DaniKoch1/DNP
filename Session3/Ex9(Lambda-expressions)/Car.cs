using System;

namespace Ex9_Lambda_expressions_
{


public class Car{
    public string color;
    public double engineSize;
    public double fuelEconomy;

    public Car(string color, double engineSize, double fuelEconomy){
        this.color=color;
        this.engineSize=engineSize;
        this.fuelEconomy=fuelEconomy;
    }
   

    

    public string ToString() => $"color: {color}, engine size: {engineSize}, fuel economy: {fuelEconomy}l per 100km";
    
}
}