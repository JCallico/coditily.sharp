using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Callicode.Codility.Exercises.Tests
{
    [TestClass]
    public class ThreeLettersTests
    {
        [TestMethod]
        public void ThreeLetters_Basic_1()
        {
            var exercise = new ThreeLetters.Solution();

            Assert.AreEqual("aabaabab", exercise.solution(5, 3));
        }

        [TestMethod]
        public void ThreeLetters_Basic_2()
        {
            var exercise = new ThreeLetters.Solution();

            Assert.AreEqual("ababab", exercise.solution(3, 3));
        }

        [TestMethod]
        public void ThreeLetters_Basic_3()
        {
            var exercise = new ThreeLetters.Solution();

            Assert.AreEqual("bbabb", exercise.solution(1, 4));
        }
    }
}
