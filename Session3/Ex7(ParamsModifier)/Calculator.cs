using System;

public class Calculator{
    public static int Add(params int[] numbers){
        int sum=0;
        foreach(int i in numbers)
            sum+=i;
        return sum;
    }
}