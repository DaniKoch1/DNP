using System;
namespace DNP
{
    namespace MathLib
    {
        class Calculator
        {
            public int Add(int a, int b) => a + b;
            public int Add(int[] numbers){
                int sum=0;
                foreach(int i in numbers){
                    sum+=i;
                }
                return sum;
            }
            public int Substraction(int a, int b) => a-b;
            public int Substraction(int[] numbers){
                int result=numbers[0];
                for(int i=1;i<numbers.Length;i++){
                    result-=numbers[i];
                }
                return result;
            }
            public int Multiplication(int a, int b) => a*b;
            public int Multiplication(int[] numbers){
                int result=numbers[0];
                for(int i=1;i<numbers.Length;i++){
                    result*=numbers[i];
                }
                return result;
            }
            public double Division(double a, int b){
                if(b==0)
                    return 0;
                else
                    return (double)a/b;
            }
           public double Division(int[] numbers){
                double result=numbers[0];
                for(int i=1;i<numbers.Length;i++){
                    result=Division(result,numbers[i]);
                }
                return result;
            }
        }
    }
}