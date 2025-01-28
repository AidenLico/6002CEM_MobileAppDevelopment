using NUnit.Framework;
using LabExercises;

namespace LabTests
{
    [TestFixture]
    public class Exercise1Tests
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(new double[] { 7, 90, 2 }, Week2Exercise1.FindLargest(new double[][] { new double[] { 4, 2, 7, 1 }, new double[] { 20, 70, 40, 90 }, new double[] { 1, 2, 0 } }));
           
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual(new double[] { 0.7634, 9.32, 9 }, Week2Exercise1.FindLargest(new double[][] { new double[] { 0.4321, 0.7634, 0.652 }, new double[] { 1.324, 9.32, 2.5423 }, new double[] { 9, 3, 6, 3 } }));
           
        }

        [Test]
        public static void Test3()
        {   
            Assert.AreEqual(new double[] { -34, -2, 7 }, Week2Exercise1.FindLargest(new double[][] { new double[] { -34, -54, -74 }, new double[] { -32, -2, -65 }, new double[] { -54, 7, -43 } }));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual(new double[] { 1.34, -1.762, 65 }, Week2Exercise1.FindLargest(new double[][] { new double[] { 0.34, -5, 1.34 }, new double[] { -6.432, -1.762, -1.99 }, new double[] { 32, 65, -6 } }));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual(new double[] { 0, 3, -2 }, Week2Exercise1.FindLargest(new double[][] { new double[] { 0, 0, 0, 0 }, new double[] { 3, 3, 3, 3 }, new double[] { -2, -2 } }));
        }
    }
}