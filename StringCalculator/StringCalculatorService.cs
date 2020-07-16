using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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

            string[] numbers = stg.Split(',');
            List<int> nbs = ConvertToInteger(numbers);

            return nbs.Sum();
        }

        private static List<int> ConvertToInteger(string[] numbers)
        {
            List<int> nbs = new List<int>();
            foreach (string number in numbers)
            {
                nbs.Add(int.Parse(number));
            }

            return nbs;
        }
    }
}
