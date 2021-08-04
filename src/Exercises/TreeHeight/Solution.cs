/*
TreeHeight
Compute the height of a binary tree.

Comments:
- Implements the most basic solution that could be potencially implemented in any programming language.
- Avoids the use of recursion, which while slower, its implementation whould have been easier to understand.
*/

namespace Callicode.Codility.Exercises.TreeHeight
{
    public class Solution
    {
        public int solution(Tree T)
        {
            if (T == null)
            {
                return -1;
            }

            var height = 0;
            var maxHeight = 0;

            Tree currentNode = T;
            Tree parentNode = null;
            Tree grandparentNode = null;

            // inspection flags to keep track of which node branches have already been evaluated
            var currentFlag = 0; // 0 - not inspected, 1 - left inspected, 2 - right inspected 
            var parentFlag = 0;
            var grandparentFlag = 0;

            while (true)
            {
                if (height > maxHeight)
                {
                    maxHeight = height;
                }

                // navigating to the left brach
                if (currentNode.l != null && currentFlag < 1)
                {
                    grandparentNode = parentNode;
                    parentNode = currentNode;
                    currentNode = currentNode.l;

                    grandparentFlag = parentFlag;
                    parentFlag = ++currentFlag;
                    currentFlag = 0;

                    height++;

                    continue;
                }

                // navigating to the right branch
                if (currentNode.r != null && currentFlag < 2)
                {
                    grandparentNode = parentNode;
                    parentNode = currentNode;
                    currentNode = currentNode.r;

                    grandparentFlag = parentFlag;
                    parentFlag = ++currentFlag;
                    currentFlag = 0;

                    height++;

                    continue;
                }

                // both branches visited, moving back to parent
                if (parentNode != null)
                {
                    currentNode = parentNode;
                    parentNode = grandparentNode;
                    grandparentNode = null;

                    currentFlag = parentFlag;
                    parentFlag = grandparentFlag;
                    grandparentFlag = 0;

                    height--;

                    continue;
                }

                // all nodes inspected, exiting loop
                break;
            }

            return maxHeight;
        }
    }

    public class Tree
    {
        public int x;
        public Tree l;
        public Tree r;
    };
}