using System;

public class Time
{
    private int hours, minutes;

    public Time(int h, int m){
        hours=h;
        minutes=m;
    }
    public int Hours{
        get{return hours;}
        set{hours=value;}
    }
    public int Minutes{
        get{return minutes;}
        set{minutes=value;}
    }

    public static Time operator +(Time time1, Time time2){
        Time sum=new Time(0, 0);
        if(time1.minutes+time2.minutes<60){
            sum.minutes=time1.minutes+time2.minutes;
            sum.hours=(time1.hours+time2.hours)%24;
        }
        else{
            sum.minutes=(time1.minutes+time2.minutes)%60;
            sum.hours=(time1.hours+time2.hours+1)%24;
        }
        return sum;
    }
    public static Time operator +(int min, Time time1){
        Time sum=new Time(0, 0);
        if(time1.minutes+min<60){
            sum.minutes=time1.minutes+min;
            sum.hours=time1.hours;
        }
        else{
            sum.minutes=(time1.minutes+min)%60;
            sum.hours=(time1.hours+1)%24;
        }
        return sum;
    }
    public override string ToString()
    {
        return $"Hours: {hours}, Minutes: {minutes}";
    }
}