using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Callicode.Codility.Exercises.Tests
{
    [TestClass]
    public class DisappearingPairsTests
    {
        [TestMethod]
        public void DisappearingPairs_Basic_1()
        {
            var exercise = new DisappearingPairs.Solution();

            Assert.AreEqual("AC", exercise.solution("ACCAABBC"));
        }

        [TestMethod]
        public void DisappearingPairs_Basic_2()
        {
            var exercise = new DisappearingPairs.Solution();

            Assert.AreEqual("", exercise.solution("ABCBBCBA"));
        }

        [TestMethod]
        public void DisappearingPairs_Basic_3()
        {
            var exercise = new DisappearingPairs.Solution();

            Assert.AreEqual("BABABA", exercise.solution("BABABA"));
        }
    }
}