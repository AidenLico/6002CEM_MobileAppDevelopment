using System;
using LabExercises;
using NUnit.Framework;

namespace LabTests
{
    [TestFixture]
    public class Exercise4Tests
    {
        [Test]
        [TestCase(399, ExpectedResult= 6)]
        [TestCase(1234, ExpectedResult=4)]
        [TestCase(153, ExpectedResult=4)]
        [TestCase(33338, ExpectedResult=5)]
        [TestCase(7777, ExpectedResult=0)]
        [TestCase(977, ExpectedResult=2)]
        [TestCase(589, ExpectedResult=4)]
        public static int SmallestTransform(int num) 
        {
            Console.WriteLine($"Input: {num}");
            return Week2Exercise4.SmallestTransform(num);
        }
    }
}