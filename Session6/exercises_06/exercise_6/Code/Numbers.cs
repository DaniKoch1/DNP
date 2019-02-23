using System;

namespace Code
{
    public class Numbers
    {
        public string numbers {get; set;}="";

        public Numbers(){
            numbers+=1;
            for(int i=2;i<=100;i++){
                if(i%3==0 && i%5==0)
                    numbers+=",FizzBuzz";
                else if(i%3==0)
                    numbers+=",Fizz";
                else if(i%5==0)
                    numbers+=",Buzz";
                else
                    numbers+=","+i;
            }
        }
    }
}
