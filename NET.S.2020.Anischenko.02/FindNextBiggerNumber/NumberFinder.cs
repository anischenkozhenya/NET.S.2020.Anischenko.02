using System;
using System.Diagnostics;

namespace FindNextBiggerNumber
{
    public static class NumberFinder
    {
        //Метод меняет элемент с индексом a и b местами
        private static void Swap(ref char a, ref char b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
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

            //индеx цифры которое делает число больше
            int n = 0;
            //Массив символов преобразованный из входящего числа 
            char[] num = number.ToString().ToCharArray();
            for (int i = num.Length - 1; i >= 0; i--)
            {
                //такова числа нет
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
            catch (OverflowException ex)
            {
                throw new OverflowException();
            }
            timerStopwatch.Stop();
            Console.WriteLine(timerStopwatch.Elapsed);
            return nextBiggerNumber;
        }
    }
}
