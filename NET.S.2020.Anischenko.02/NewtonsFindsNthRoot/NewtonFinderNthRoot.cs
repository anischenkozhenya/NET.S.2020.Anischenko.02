using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonsFindsNthRoot
{
    public static class NewtonFinderNthRoot
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="n"></param>
        /// <param name="accuracy"></param>
        /// <returns></returns>
        public static double FindNthRoot(double number, int n, double accuracy)
        {
            if (n <= 0)
                throw new ArgumentException();

            if ((number <= 0) && (n % 2 == 0))
                throw new ArgumentException();

            if (accuracy <= 0)
                throw new ArgumentException();
            double res =0;
            return res;
        }
    }
}
