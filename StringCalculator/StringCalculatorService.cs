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

            string[] delimiter;
            string stgWithNumbers;
            if (stg.StartsWith("//"))
            {
                delimiter = new string[] { stg.Substring(2, 1) };
                stgWithNumbers = stg.Substring(4);
            }
            else
            {
                delimiter = new string[] { ",", "\n" };
                stgWithNumbers = stg;
            }

            string[] numbers = stgWithNumbers.Split(delimiter, StringSplitOptions.None);
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
