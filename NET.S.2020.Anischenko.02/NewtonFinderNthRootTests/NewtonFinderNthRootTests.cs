
using NUnit.Framework;
using NewtonsFindsNthRoot;
using System;

namespace NewtonFinderNthRootTests
{
    [TestFixture]
    public class NewtonFinderNthRootTests
    {
        [TestCase(1, 5, 0.0001, ExpectedResult = 1)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.001, 3, 0.0001, ExpectedResult = 0.1)]
        [TestCase(0.04100625, 4, 0.0001, ExpectedResult = 0.45)]
        [TestCase(8, 3, 0.0001, ExpectedResult = 2)]
        [TestCase(0.0279936, 7, 0.0001, ExpectedResult = 0.6)]
        [TestCase(0.0081, 4, 0.1, ExpectedResult = 0.3)]
        [TestCase(-0.008, 3, 0.1, ExpectedResult = -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, ExpectedResult = 0.545)]
        public double InsertNumberTest(double number, int root, double accuracy) => NewtonFinderNthRoot.FindNthRoot(number, root,accuracy);

        [TestCase(8, 15,-0.1)]// <-ArgumentOutOfRangeException
        [TestCase(8, -1, 0.1)]// <-ArgumentOutOfRangeException
        [TestCase(-8, 2, 0.1)]// <-ArgumentOutOfRangeException	
        public void MethodName_Number_Degree_Precision_ArgumentOutOfRangeException(double number, int root, double accuracy)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => NewtonFinderNthRoot.FindNthRoot(number, root, accuracy));
        }

    }
}
