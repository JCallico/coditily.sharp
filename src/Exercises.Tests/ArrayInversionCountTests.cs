using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Callicode.Codility.Exercises.Tests
{
    [TestClass]
    public class ArrayInversionCountTests
    {
        [TestMethod]
        public void ArrayInversionCount_Basic_1()
        {
            var x = new int[] { -1, 6, 3, 4, 7, 4 };

            var exercise = new ArrayInversionCount.Solution();

            Assert.AreEqual(4, exercise.solution(x));
        }

        [TestMethod]
        public void ArrayInversionCount_Basic_2()
        {
            var x = new int[] { -1, 6, 3, 4, 6, 4, 2 };

            var exercise = new ArrayInversionCount.Solution();

            Assert.AreEqual(9, exercise.solution(x));
        }
    }
}
