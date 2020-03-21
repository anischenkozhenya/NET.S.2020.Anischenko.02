using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextBiggerNumber
{
    public static partial class NumberFinder
    {
        /// <summary>
        /// Сalculates the execution time of the passed method and returns the result of the execution  
        /// </summary>
        /// <param name="func">The tested Method</param>
        /// <param name="time">Time of the execution</param>
        /// <param name="number">Value</param>
        /// <returns></returns>
        static int? CalculateTime(Func<int,int?> func,int number, out long time)
        {
            var timer = new Stopwatch();
            timer.Start();
            var result = func.Invoke(number);
            timer.Stop();
            time = timer.ElapsedMilliseconds;
            return result;
        }
    }
}
