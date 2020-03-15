using System;
using NUnit.Framework;
using FindNumberWithDigit;

namespace FilterDigitTests
{
    [TestFixture]
    public class FilterDigitTests
    {
        //[TestCase(7, 1, 2, 3, 4, 5, 6, 68, 69, 15, ExpectedResult = null)]
        [TestCase(7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17, ExpectedResult = new int[]{7,70, 17})]
        [TestCase(7, 1, 2, 3, 4, 5, 6, 68, 69,15,  ExpectedResult = new int[] { })]
        [TestCase(7, 1, 2, 3, 4, 5, 6, 68, 69, int.MaxValue, ExpectedResult = new int[] {int.MaxValue })]
        public int[] FilterDigitTest(int digit, params int[] numbers) => FinderNumberWithDigit.FilterDigit(digit, numbers);

        [TestCase(-7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17)]
        [TestCase(22, 1, 2, 3, 4, 5, 6, 68, 69, 15)]
        public void DigitArgumentOutOfRangeException(int digit, params int[] numbers)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => FinderNumberWithDigit.FilterDigit(digit, numbers));
        }
        [TestCase(1)]
        [TestCase(5)]
        public void DigitArgumentNullExceptions(int digit, params int[] numbers)
        {
            Assert.Throws<ArgumentNullException>(() => FinderNumberWithDigit.FilterDigit(digit, numbers));
        }
    }
}
