using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fraction
{
    public class Fraction
    {
        private int numerator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        private int denominator;
        public int Denominator
        {
            get { return denominator; }
            set 
            {
                if (value == 0) throw new DenominatorisZeroException();
                else denominator = value; 
            }
        }
        public Fraction()
        {
            Numerator = Denominator = 1;           
        }
        public Fraction(int num, int den)
        {
            Numerator = num;
            Denominator = den;
        }
        public override string ToString()
        {
            string info = Numerator + "/" + Denominator;
            return info;
        }
        public Fraction Add(Fraction f)
        {
            int newDenominator = Denominator * f.Denominator;
            int newNumerator = Numerator * f.Denominator + Denominator * f.Numerator;
            Fraction output = new Fraction(newNumerator, newDenominator); 
            return output;
        }
        public Fraction Sub(Fraction f)
        {
            int newDenominator = Denominator * f.Denominator;
            int newNumerator = Numerator * f.Denominator - Denominator * f.Numerator;
            Fraction output = new Fraction(newNumerator, newDenominator); 
            return output;
        }
        public Fraction Mul(Fraction f)
        {
            int newNumerator = Numerator * f.Numerator;
            int newDenominator = Denominator * f.Denominator;
            Fraction output = new Fraction(newNumerator, newDenominator);
            return output;
        }
        public Fraction Div(Fraction f)
        {
            int newNumerator = Numerator * f.Denominator;
            int newDenominator = Denominator * f.Numerator;
            Fraction output = new Fraction(newNumerator, newDenominator);
            return output;
        }
    }
}