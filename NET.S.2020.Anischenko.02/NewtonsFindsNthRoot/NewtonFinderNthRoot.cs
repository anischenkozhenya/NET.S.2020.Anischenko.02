using System;

namespace NewtonsFindsNthRoot
{
    public static class NewtonFinderNthRoot
    {
        /// <summary>
        /// Returns the root of Nth power from number with a given accurasy
        /// </summary>
        /// <param name="number"></param>
        /// <param name="n">Degree</param>
        /// <param name="accuracy"></param>
        /// <returns></returns>
        public static double FindNthRoot(double number, int n, double accuracy)
        {
            if (n <= 0)
                throw new ArgumentOutOfRangeException();
            if ((number <= 0) && (n % 2 == 0))                 //-0.3^3=-0.027
                throw new ArgumentOutOfRangeException();
            if (accuracy <= 0)
                throw new ArgumentOutOfRangeException();
            int digitAccurancy = 0;
            double temp = accuracy;
            while(temp!=1)
            {
                temp *= 10;
                digitAccurancy += 1;
            }
            double x0 = number / n;
            double x1 = (1.0 / n) * ((n - 1) * 1 + (number / Math.Pow(1, n - 1)));
            while (Math.Abs(x1-x0) > accuracy/100)
            {
                x0 = x1;
                x1 = (1.0 / n) * ((n - 1) * x0 + (number / (Math.Pow(x0, n - 1))));
            } 
            return Math.Round(x1,digitAccurancy);
        }
    }
}
