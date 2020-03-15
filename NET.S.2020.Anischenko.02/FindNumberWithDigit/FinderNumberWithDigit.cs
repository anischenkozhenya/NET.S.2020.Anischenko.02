using System;
using System.Collections.Generic;

namespace FindNumberWithDigit
{
    public static class FinderNumberWithDigit
    {
        //public static int?[] FilterDigit(int digit, params int[] numbers)
        /// <summary>
        /// Returns array of numbers which contains digit
        /// </summary>
        /// <param name="digit">Digit</param>
        /// <param name="numbers">Numbers</param>
        /// <returns>Array of numbers which contains digit</returns>
        public static int[] FilterDigit(int digit, params int[] numbers)
        {
            if (digit<0||digit>9)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (numbers.Length==0)
            {
                throw new ArgumentNullException();
            }
            var digitChar= digit.ToString();
            var resultsNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (number.ToString().Contains(digitChar))
                {
                    resultsNumbers.Add(number);
                }
            }
            //return resultsNumbers.Count == 0 ? null : resultsNumbers.ToArray();
            return resultsNumbers.ToArray();
        } 
    }
}
