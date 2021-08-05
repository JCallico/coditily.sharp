using Callicode.Codility.Exercises.TreeHeight;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Callicode.Codility.Exercises.Tests
{
    [TestClass]
    public class TreeHeightTests
    {
        [TestMethod]
        public void TreeHeight_Zero_Node()
        {
            var tree = (Tree)null;

            var exercise = new TreeHeight.Solution();

            Assert.AreEqual(-1, exercise.solution(tree));
        }

        [TestMethod]
        public void TreeHeight_One_Node()
        {
            var tree = new Tree
            {
                x = 5
            };

            var exercise = new TreeHeight.Solution();

            Assert.AreEqual(0, exercise.solution(tree));
        }

        [TestMethod]
        public void TreeHeight_Basic_1()
        {
            var tree = new Tree
            {
                x = 5,
                l = new Tree
                {
                    x = 3,
                    l = new Tree
                    {
                        x = 20
                    },
                    r = new Tree
                    {
                        x = 21
                    }
                },
                r = new Tree
                {
                    x = 10,
                    l = new Tree
                    {
                        x = 1
                    }
                }
            };

            var exercise = new TreeHeight.Solution();

            Assert.AreEqual(2, exercise.solution(tree));
        }

        [TestMethod]
        public void TreeHeight_Basic_2()
        {
            var tree = new Tree
            {
                x = 5,
                l = new Tree
                {
                    x = 3,
                    l = new Tree
                    {
                        x = 20
                    },
                    r = new Tree
                    {
                        x = 21,
                        r = new Tree
                        {
                            x = 31,
                            l = new Tree
                            {
                                x = 41,
                                l = new Tree
                                {
                                    x = 51
                                }
                            },
                            r = new Tree
                            {
                                x = 42
                            }
                        }
                    }
                },
                r = new Tree
                {
                    x = 10,
                    l = new Tree
                    {
                        x = 1
                    }
                }
            };

            var exercise = new TreeHeight.Solution();

            Assert.AreEqual(5, exercise.solution(tree));
        }
    }
}
