using System;

namespace q1
{
    public class Fraction
    {
        public int numerator {get; set;}
        public int denumerator {get; set;}
        public Fraction(int num, int denum){
            numerator=num;
            denumerator=denum;
        }
        public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a.numerator * b.numerator, a.denumerator * b.denumerator);
        
        public override string ToString() => $"{numerator}/{denumerator}";
    }
}