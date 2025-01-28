using NUnit.Framework;
using LabExercises;

namespace LabTests
{
    public class Exercise2Tests
    {

        [Test]
        public void Test1()
            => Assert.AreEqual("$240.00", Week2Exercise2.OverTime(new[] { 9, 17, 30, 1.5 }));

        [Test]
        public void Test2()
            => Assert.AreEqual("$400.00", Week2Exercise2.OverTime(new double[] { 9, 18, 40, 2 }));

        [Test]
        public void Test3()
            => Assert.AreEqual("$325.00", Week2Exercise2.OverTime(new[] { 13, 20, 32.5, 2 }));

        [Test]
        public void Test4()
            => Assert.AreEqual("$100.00", Week2Exercise2.OverTime(new[] { 9, 13, 25, 1.5 }));

        [Test]
        public void Test5()
            => Assert.AreEqual("$364.00", Week2Exercise2.OverTime(new[] { 11.5, 19, 40, 1.8 }));

        [Test]
        public void Test6()
            => Assert.AreEqual("$210.00", Week2Exercise2.OverTime(new[] { 10, 17, 30, 1.5 }));

        [Test]
        public void Test7()
            => Assert.AreEqual("$209.63", Week2Exercise2.OverTime(new[] { 10.5, 17, 32.25, 1.5 }));

        [Test]
        public void Test8()
            => Assert.AreEqual("$84.00", Week2Exercise2.OverTime(new[] { 16, 18, 30, 1.8 }));

        [Test]
        public void Test9()
            => Assert.AreEqual("$130.00", Week2Exercise2.OverTime(new[] { 18, 20, 32.5, 2 }));

        [Test]
        public void test10()
            => Assert.AreEqual("$52.50", Week2Exercise2.OverTime(new[] { 13.25, 15, 30, 1.5 }));

        [Test]
        public void Test11()
            => Assert.AreEqual("$432.32", Week2Exercise2.OverTime(new[] { 13, 21, 38.6, 1.8 }));
    }
}