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
            if (numbers.Length > 0)
            {
                List<int> nbs = new List<int>();
                foreach (string number in numbers)
                {
                    nbs.Add(int.Parse(number));
                }

                return nbs.Sum();
            }

            return int.Parse(stg);
        }
    }
}
