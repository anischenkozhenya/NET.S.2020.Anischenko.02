using System;
using System.Diagnostics;

namespace FindNextBiggerNumber
{
    public static class NumberFinder
    {
        /// <summary>
        /// Swap value of numbers by reference
        /// </summary>
        /// <param name="a">first number</param>
        /// <param name="b">second number</param>
        private static void Swap(ref char a, ref char b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
        /// <summary>
        /// Returns next bigger number from the same numbers
        /// </summary>
        /// <param name="number"></param>
        /// <returns>next bigger number</returns>
        public static int? FindNextBiggerNumber(int number)
        {
            Stopwatch timerStopwatch= new Stopwatch();
            timerStopwatch.Start();
            int nextBiggerNumber;

            if (number < 9 && number > 0)
            {
                return null;
            }
            if (number <= 0)
                throw new ArgumentException();
            int n = 0;
            char[] num = number.ToString().ToCharArray();
            for (int i = num.Length - 1; i >= 0; i--)
            {
                //если такова числа нет
                if (i == 0)
                {
                    return null;
                }
                if (num[i] > num[i - 1])
                {
                    n = i;
                    break;
                }
            }
            //цифра которую заменит ближайшая большая 
            char x = num[n - 1];
            //число большее чем x и меньшее следующее за x
            int smallest = n;
            for (int j = n; j < num.Length; j++)
            {
                if (num[j] > x && num[j] < num[smallest])
                {
                    smallest = j;
                }
            }
            Swap(ref num[smallest], ref num[n - 1]);
            bool checker = false;
            //сортировка
            do
            {
                for (int i = n + 1; i < num.Length; i++)
                {
                    if (num[i] < num[i - 1])
                    {
                        Swap(ref num[i], ref num[i - 1]);
                        checker = true;
                        break;
                    }
                    if (num[i] >= num[i - 1] && i == num.Length - 1)
                    {
                        checker = false;
                    }
                }
            }while(checker);
            try
            {
                nextBiggerNumber = checked(int.Parse(new string(num)));
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
            timerStopwatch.Stop();
            Console.WriteLine(timerStopwatch.Elapsed);
            return nextBiggerNumber;
        }
    }
}
