using System;
using System.Collections.Generic;

class StackClass<T>{
    public static void add(Stack<T> stack, params T[] values){
        foreach(T e in values)
            stack.Push(e);
    }
    public static string toString(Stack<T> stack){
        string print="";
        foreach(T e in stack)
            print+=e.ToString()+", ";
        return print;
    }
}