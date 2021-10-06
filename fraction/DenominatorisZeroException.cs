using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fraction
{
    public class DenominatorisZeroException : Exception
    {
        public DenominatorisZeroException() : base("Denominator is zero")
        {}
        public DenominatorisZeroException(String message) : base(message)
        {}
    }
}