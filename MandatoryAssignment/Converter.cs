using System;

namespace MandatoryAssignment
{
    public class Converter
    {
        public const double Udregn = 28.34952;

        public static double ToGram(double Ounce)
        {
            return Ounce * Udregn;
        }

        public static double ToOunce(double Gram)
        {
            return Gram / Udregn;
        }
    }
}
