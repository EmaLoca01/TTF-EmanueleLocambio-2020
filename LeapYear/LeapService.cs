using System;

namespace LeapYear
{
    public class LeapService
    {
        public static bool IsLeap(int number)
        {
            return number % 4 == 0;
        }

        public static bool IsSecolar(int number)
        {
            return number % 100 != 0 || number % 400 == 0;
        }

        public static bool IsGiulian(int number)
        {
            return number % 4 == 0 && number <= 1581;
        }

        public static bool IsBeforeZero(int number)
        {
            return number < 0;
        }

        public static bool IsZero(int number)
        {
            return number == 0;
        }
    }
}
