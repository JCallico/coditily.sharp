using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Callicode.Codility.Exercises.Tests
{
    [TestClass]
    public class StrSymmetryPointTests
    {
        [TestMethod]
        public void TreeHeightTests_None()
        {
            var exercise = new StrSymmetryPoint.Solution();

            Assert.AreEqual(-1, exercise.solution("word"));
        }

        [TestMethod]
        public void TreeHeightTests_One()
        {
            var exercise = new StrSymmetryPoint.Solution();

            Assert.AreEqual(0, exercise.solution("x"));
        }

        [TestMethod]
        public void TreeHeightTests_Basic_2()
        {
            var exercise = new StrSymmetryPoint.Solution();

            Assert.AreEqual(3, exercise.solution("racecar"));
        }

        [TestMethod]
        public void TreeHeightTests_Basic_3()
        {
            var exercise = new StrSymmetryPoint.Solution();

            Assert.AreEqual(-1, exercise.solution("racexcar"));
        }

        [TestMethod]
        public void TreeHeightTests_Basic_4()
        {
            var exercise = new StrSymmetryPoint.Solution();

            Assert.AreEqual(9, exercise.solution("raceeeeeeeeeeeeecar"));
        }
    }
}
