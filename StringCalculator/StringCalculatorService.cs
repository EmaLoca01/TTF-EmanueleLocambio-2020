using System;
using System.ComponentModel;

namespace StringCalculator
{
    public class StringCalculatorService
    {
        public static int Add(string stg)
        {
            if (stg.Length == 0)
            {
                return 0;
            }
            else
            {
                return int.Parse(stg);
            }
        }
    }
}
