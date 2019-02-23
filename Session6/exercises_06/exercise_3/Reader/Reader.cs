using System;
using System.IO;

namespace reader
{
    public class Class1
    {
        static void Main(string[] args)
        {
        int max=0;
            string maxWord="";
            try{
                using(var sr=new StreamReader("Test.txt")){
                    string line;
                    while((line=sr.ReadLine())!=null){
                        Array a=line.Split(" ");
                        foreach(string s in a)
                            if(s.Length>maxWord.Length){
                                max=s.Length;
                                maxWord=s;
                            }
                    }
                    System.Console.WriteLine(maxWord);
                }
            }
            catch(Exception e){
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
