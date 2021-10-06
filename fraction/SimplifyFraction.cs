using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fraction
{
    public class SimplifyFraction : Fraction
    {
        public SimplifyFraction()
        {
            Numerator = Denominator = 1;
        }
        public SimplifyFraction(int num, int den)
        {
            Numerator = num;
            Denominator = den;
        }
        public override string ToString()
        {
            int temp = 0, maxDivisor = 1;
            if (Numerator < Denominator)
            {
                temp = Numerator;
            }
            else temp = Denominator;
            for (int i = 1; i <= temp; i++)
            {
                if (Numerator % i == 0 && Denominator % i == 0)
                {
                    if (maxDivisor < i)
                    {
                        maxDivisor = i;
                    }
                }
            }
            string info = (Numerator / maxDivisor) + "/" + (Denominator / maxDivisor);
            return info;
        }
    }
}