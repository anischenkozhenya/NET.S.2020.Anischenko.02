using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertBiteInNumber
{
    /// <summary>
    /// Inserts bits of the 2nd number starting from position startPosition to endPosition
    /// to the 1st number.
    /// </summary>
    public static class InserterNumber
    {
        /// <summary>
        /// Inserts bits of the 2nd number starting from position startPosition to endPosition
        /// </summary>
        /// <param name="numberSource"></param>
        /// <param name="numberIn"></param>
        /// <param name="startPositionBit"></param>
        /// <param name="endPositionBit"></param>
        /// <returns></returns>
        public static int InsertNumber(int numberSource, int numberIn, int startPositionBit, int endPositionBit)
        {
            if (startPositionBit > 31 || startPositionBit < 0 || endPositionBit > 31 || endPositionBit < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (startPositionBit > endPositionBit)
            {
                throw new ArgumentException();
            }
            /*endPositionBit - startPositionBit   8-3 =5
                *2<<5     00000000000000000010 => 000000000001000000    =64
                *64-1 = 63   000000000000111111
                *63<<3       000000000000111111000  504*/
            int mask = ((2 << (endPositionBit - startPositionBit)) - 1) << startPositionBit;
            /*  ~mask  111111111111000000111
             firstNumber & ~mask  9 => 00000000001001 & 111111111111000000111=000000000000001
             secondNumber << startPositionBit    00000000000001111 => 000000000000000001111000 120
             000000000000001 | 000000001111000   =>  000000001111001 
             */
            return (numberSource & ~mask) | ((numberIn << startPositionBit) & mask);
        }
    }
}
