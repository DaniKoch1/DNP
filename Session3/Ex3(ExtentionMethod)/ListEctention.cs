using System;
using System.Collections.Generic;

public static class ListExtention
{
    public static T RandomElement<T>(this List<T> list){
        Random rnd=new Random();
        return list[rnd.Next(0,list.Count)];
        //list.Randomize()
    }
    public static List<T> Shuffle<T>(this List<T> list){
        List<T> helper=new List<T>();
        Random rnd=new Random();
        int i=list.Count;
        while(i>0){
            T element=list[rnd.Next(0,list.Count)];
            helper.Add(element);
            list.Remove(element);
            i--;
        }
        return helper;
    }
    public static string toString<T>(List<T> list){
        string print="";
        foreach(T e in list)
            print+=e.ToString();
        return print;
    }
}