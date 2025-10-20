using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Callicode.Codility.Exercises.Tests
{
    [TestClass]
    public class SocksLaunderingTests
    {
        [TestMethod]
        public void SocksLaundering_Basic_1()
        {
            var exercise = new SocksLaundering.Solution();

            Assert.AreEqual(3,
                exercise.solution(2, new[] { 1, 2, 1, 1 }, new[] { 1, 4, 3, 2, 4 }));
        }

        [TestMethod]
        public void SocksLaundering_Basic_2()
        {
            var exercise = new SocksLaundering.Solution();

            Assert.AreEqual(4,
                exercise.solution(4, new[] { 1, 2, 1, 1 }, new[] { 1, 4, 3, 2, 4 }));
        }

        [TestMethod]
        public void SocksLaundering_Basic_3()
        {
            var exercise = new SocksLaundering.Solution();

            Assert.AreEqual(3,
                exercise.solution(4, new[] { 1, 1, 1, 1 }, new[] { 1, 4, 3, 2, 4 }));
        }

        [TestMethod]
        public void SocksLaundering_NoWashingCapacity()
        {
            var exercise = new SocksLaundering.Solution();

            // K=0, should only count existing pairs in clean socks
            Assert.AreEqual(3,
                exercise.solution(0, new[] { 1, 1, 2, 2, 3, 4, 4 }, new[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void SocksLaundering_OnlyCleanSocks()
        {
            var exercise = new SocksLaundering.Solution();

            // No dirty socks, should only count clean pairs
            Assert.AreEqual(2,
                exercise.solution(10, new[] { 1, 1, 2, 3, 4, 5, 6, 6 }, new int[] { }));
        }

        [TestMethod]
        public void SocksLaundering_OnlyDirtySocks()
        {
            var exercise = new SocksLaundering.Solution();

            // No clean socks, can only make pairs from dirty socks
            Assert.AreEqual(2,
                exercise.solution(4, new int[] { }, new[] { 1, 1, 2, 2, 3, 3 }));
        }

        [TestMethod]
        public void SocksLaundering_SingleSockWashing()
        {
            var exercise = new SocksLaundering.Solution();

            // K=1, can wash one dirty sock to pair with clean single
            Assert.AreEqual(2,
                exercise.solution(1, new[] { 1, 1, 2 }, new[] { 2, 3, 3 }));
        }

        [TestMethod]
        public void SocksLaundering_PerfectMatching()
        {
            var exercise = new SocksLaundering.Solution();

            // Perfect scenario: each clean single has a dirty match, K=3 can wash 3 singles
            Assert.AreEqual(3,
                exercise.solution(3, new[] { 1, 2, 3 }, new[] { 1, 2, 3, 4, 4 }));
        }

        [TestMethod]
        public void SocksLaundering_ExcessWashingCapacity()
        {
            var exercise = new SocksLaundering.Solution();

            // More washing capacity than needed
            Assert.AreEqual(3,
                exercise.solution(50, new[] { 1, 1, 2 }, new[] { 2, 3, 3 }));
        }

        [TestMethod]
        public void SocksLaundering_AllSameColor()
        {
            var exercise = new SocksLaundering.Solution();

            // All socks are the same color
            Assert.AreEqual(4,
                exercise.solution(6, new[] { 1, 1 }, new[] { 1, 1, 1, 1, 1, 1 }));
        }

        [TestMethod]
        public void SocksLaundering_NoMatchingColors()
        {
            var exercise = new SocksLaundering.Solution();

            // Clean and dirty socks have no matching colors, can wash 2 pairs of dirty socks
            Assert.AreEqual(4,
                exercise.solution(4, new[] { 1, 1, 2, 2 }, new[] { 3, 3, 4, 4 }));
        }

        [TestMethod]
        public void SocksLaundering_EdgeCase_MaxValues()
        {
            var exercise = new SocksLaundering.Solution();

            // Edge case with maximum values
            var cleanSocks = new int[50];
            var dirtySocks = new int[50];
            
            // Fill with alternating colors to test various scenarios
            for (int i = 0; i < 50; i++)
            {
                cleanSocks[i] = (i % 25) + 1;  // Colors 1-25, each appears twice
                dirtySocks[i] = (i % 25) + 1;  // Same pattern
            }

            // Should be able to make 50 pairs (25 colors × 2 pairs each)
            Assert.AreEqual(50,
                exercise.solution(50, cleanSocks, dirtySocks));
        }

        [TestMethod]
        public void SocksLaundering_OptimalStrategy()
        {
            var exercise = new SocksLaundering.Solution();

            // Test optimal strategy: prefer matching singles over washing pairs
            Assert.AreEqual(2,
                exercise.solution(3, new[] { 1, 2, 3 }, new[] { 1, 2, 4, 4, 4, 4 }));
        }

        [TestMethod]
        public void SocksLaundering_LimitedByWashingCapacity()
        {
            var exercise = new SocksLaundering.Solution();

            // Many dirty socks but limited washing capacity
            Assert.AreEqual(1,
                exercise.solution(2, new[] { 1 }, new[] { 1, 2, 2, 3, 3, 4, 4 }));
        }

        [TestMethod]
        public void SocksLaundering_MixedScenario()
        {
            var exercise = new SocksLaundering.Solution();

            // Complex scenario with various combinations
            Assert.AreEqual(5,
                exercise.solution(6, new[] { 1, 1, 2, 3, 4 }, new[] { 2, 3, 4, 5, 5, 6, 6 }));
        }
    }
}
