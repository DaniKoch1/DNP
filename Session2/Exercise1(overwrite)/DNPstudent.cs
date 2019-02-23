using System;

public class DNPstudent :Student{
    public override void Hi(){
        base.Hi();
        System.Console.WriteLine("Hi, I'm a DNP student!");
    }
}