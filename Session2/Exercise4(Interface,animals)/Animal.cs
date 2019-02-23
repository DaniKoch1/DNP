using System;
using System.Collections;
namespace Exercise4_Interface_animals_
{
public class Animal: IComparable{
    private string type { get;}
    private double weight {get;}
    private int speed {get;}
    public Animal(string type, double weight, int speed){
        this.type=type;
        this.weight=weight;
        this.speed=speed;
    }

    

    public override string ToString(){
        return $"type: {type}\nweight: {weight}\nspeed: {speed}";
    }

    public int CompareTo(Object obj)
    {
        Animal other=(Animal)obj;
        if(this.weight<other.weight)
            return -1;
        else if(this.weight>other.weight)
            return 1;
        else
            return 0;
    }
    }
        
}