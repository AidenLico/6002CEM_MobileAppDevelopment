using NUnit.Framework;
using LabExercises;

namespace LabTests
{
    [TestFixture]
    public class Exercise3Tests
    {
        [Test]
        [TestCase(new int[]{5, 1, 4, 3, 2}, ExpectedResult=true)]
        [TestCase(new int[]{55, 59, 58, 56, 57}, ExpectedResult=true)]
        [TestCase(new int[]{-3, -2, -1, 1, 0}, ExpectedResult=true)]
        [TestCase(new int[]{5, 1, 4, 3, 2, 8}, ExpectedResult=false)]
        [TestCase(new int[]{5, 6, 7, 8, 9, 9}, ExpectedResult=false)]
        [TestCase(new int[]{5, 3}, ExpectedResult=false)]
        public static bool FixedTest(int[] arr) =>
            Week2Exercise3.ConsecutiveNumbers(arr);
    }
}