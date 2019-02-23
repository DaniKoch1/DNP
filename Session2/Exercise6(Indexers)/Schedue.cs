using System;
using System.Collections;

public class Schedule{
    private Hashtable schedule=new Hashtable();

    public String this[DateTime d]{
        get => (String)schedule[d];
        set => schedule.Add(d, value);
    }
    public String this[string s]{
        get => (String)schedule[DateTime.Parse(s)];
        set => schedule.Add(DateTime.Parse(s), value);
    }
    
}