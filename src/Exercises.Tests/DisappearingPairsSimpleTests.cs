using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Callicode.Codility.Exercises.Tests
{
    [TestClass]
    public class DisappearingPairsSimpleTests
    {
        [TestMethod]
        public void DisappearingPairsSimple_Basic_1()
        {
            var exercise = new DisappearingPairsSimple.Solution();

            Assert.AreEqual("AC", exercise.solution("ACCAABBC"));
        }

        [TestMethod]
        public void DisappearingPairsSimple_Basic_2()
        {
            var exercise = new DisappearingPairsSimple.Solution();

            Assert.AreEqual("", exercise.solution("ABCBBCBA"));
        }

        [TestMethod]
        public void DisappearingPairsSimple_Basic_3()
        {
            var exercise = new DisappearingPairsSimple.Solution();

            Assert.AreEqual("BABABA", exercise.solution("BABABA"));
        }
    }
}
