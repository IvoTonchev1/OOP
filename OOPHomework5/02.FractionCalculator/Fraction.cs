using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.FractionCalculator
{
    public struct Fraction
    {
        private long denominator;

        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator { get; set; }

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be zero.");
                }
                this.denominator = value;
            }
        }
        public static Fraction operator +(Fraction fracA, Fraction fracB)
        {
            BigInteger resultNumerator = ((BigInteger)fracA.Numerator * fracB.Denominator) +
                             ((BigInteger)fracA.Denominator * fracB.Numerator);

            BigInteger resultDenominator = (BigInteger)fracA.Denominator * fracB.Denominator;

            BigInteger gcd = GetGreatestCommonDivisor(resultNumerator, resultDenominator);

            if (gcd > 1)
            {
                resultNumerator /= gcd;
                resultDenominator /= gcd;
            }

            if (resultNumerator < long.MinValue || long.MaxValue < resultNumerator)
            {
                throw new ArithmeticException("Numerator of resulting fraction is either too large or too small.");
            }

            if (resultDenominator > long.MaxValue)
            {
                throw new ArithmeticException("Denominator of resulting fraction is too large.");
            }

            return new Fraction((long)resultNumerator, (long)resultDenominator);
        }
        public static Fraction operator -(Fraction fracA, Fraction fracB)
        {
            Fraction result = fracA + new Fraction(fracB.Numerator * -1, fracB.Denominator);
            return result;
        }
        public override string ToString()
        {
            return string.Format("{0}", (double)this.Numerator / this.Denominator);
        }
        private static long GetGreatestCommonDivisor(BigInteger numerator, BigInteger denominator)
        {
            if (numerator < 0)
            {
                numerator *= -1;
            }
            if (denominator < 0)
            {
                denominator *= -1;
            }
            while (denominator != 0)
            {
                BigInteger tempDenominator = denominator;
                denominator = numerator % denominator;
                numerator = tempDenominator;
            }
            return (long)numerator;
        }
    }
}
