using System;

namespace LeapYear
{
    public class LeapService
    {
        public static bool IsEven(int number)
        {
            return number % 4 == 0 && number % 100 != 0;
        }
    }
}
