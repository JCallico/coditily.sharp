using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Callicode.Codility.Exercises.Tests
{
    [TestClass]
    public class ThreeLettersRecursiveTests
    {
        [TestMethod]
        public void ThreeLettersRecursive_Basic_1()
        {
            var exercise = new ThreeLettersRecursive.Solution();

            Assert.AreEqual("aabaabab", exercise.solution(5, 3));
        }

        [TestMethod]
        public void ThreeLettersRecursive_Basic_2()
        {
            var exercise = new ThreeLettersRecursive.Solution();

            Assert.AreEqual("aababb", exercise.solution(3, 3));
        }

        [TestMethod]
        public void ThreeLettersRecursive_Basic_3()
        {
            var exercise = new ThreeLettersRecursive.Solution();

            Assert.AreEqual("bbabb", exercise.solution(1, 4));
        }
    }
}
