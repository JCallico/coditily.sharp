using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Callicode.Codility.Exercises.Tests
{
    [TestClass]
    public class ParityDegreeTests
    {
        [TestMethod]
        public void ParityDegree_Basic_1()
        {
            var exercise = new ParityDegree.Solution();

            Assert.AreEqual(3, exercise.solution(24));
        }

        [TestMethod]
        public void ParityDegree_Zero()
        {
            var exercise = new ParityDegree.Solution();

            Assert.AreEqual(0, exercise.solution(1));
        }

        [TestMethod]
        public void ParityDegree_One()
        {
            var exercise = new ParityDegree.Solution();

            Assert.AreEqual(0, exercise.solution(1));
        }
    }
}
