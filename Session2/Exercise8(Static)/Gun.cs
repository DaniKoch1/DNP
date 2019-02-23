using System;

class Gun{
    public static int gunCount;
    public static int shotsFired;
    public int bulletCount=10;

    public Gun(){
        gunCount++;
    }
    public void Shoot(){
        System.Console.WriteLine("BANG!");
        shotsFired++;
        bulletCount--;
    }

}