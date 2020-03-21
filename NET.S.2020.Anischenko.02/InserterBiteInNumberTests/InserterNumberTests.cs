using NUnit.Framework;
using InsertBiteInNumber;
using System;

namespace InserterBiteInNumberTests
{
    [TestFixture]
    public class InserterNumberTests
    {
        [TestCase(9,15,3,8, ExpectedResult =121 )]
        [TestCase(15, 15, 0, 0, ExpectedResult = 15)]
        [TestCase(8, 15, 0, 0, ExpectedResult = 9)]
        [TestCase(31, 9, 1, 4, ExpectedResult = 19)]
        public int InsertNumberSimpleTest(int firstNumber,int secondNumber,int startPositionBit,int endPositionBite) => InserterNumber.InsertNumber(firstNumber,secondNumber,startPositionBit,endPositionBite);
        
        [TestCase(325,13,-1,3)]
        [TestCase(325,13,-1,-5)]
        public void InsertNumberStartOrEndBitLessZeroArgumentOutOfRangeException(int numberSource,int numberIn, int startPositionBit, int endPositionBit)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>InserterNumber.InsertNumber(numberSource,numberIn,startPositionBit,endPositionBit));
        }

        [TestCase(234, 13, 2, 1)]
        public void InsertNumberEndBitLessThenStartBitArgumentException(int numberSource, int numberIn, int startPositionBit, int endPositionBit)
        {
            Assert.Throws<ArgumentException>(() => InserterNumber.InsertNumber(numberSource, numberIn, startPositionBit, endPositionBit));
        }
    }
}
