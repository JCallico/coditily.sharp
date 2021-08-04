/*
TreeHeight
Compute the height of a binary tree.
https://app.codility.com/programmers/trainings/4/tree_height/
*/

using System;
using System.Collections.Generic;
using System.Linq;

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

            var heightDictionary = new Dictionary<Tree, int>();
            var height = 0;

            Tree currentNode = T;
            Tree parentNode = null;
            Tree grandparentNode = null;

            while (true)
            {
                if (!heightDictionary.ContainsKey(currentNode))
                {
                    heightDictionary.Add(currentNode, height);
                }

                // finding height to the left                
                if (currentNode.l != null && !heightDictionary.ContainsKey(currentNode.l))
                {
                    grandparentNode = parentNode;
                    parentNode = currentNode;
                    currentNode = currentNode.l;
                    height++;

                    continue;
                }

                // finding height to the right
                if (currentNode.r != null && !heightDictionary.ContainsKey(currentNode.r))
                {
                    grandparentNode = parentNode;
                    parentNode = currentNode;
                    currentNode = currentNode.r;
                    height++;

                    continue;
                }

                // moving back to parent
                if (parentNode != null)
                {
                    currentNode = parentNode;
                    parentNode = grandparentNode;
                    grandparentNode = null;
                    height--;

                    continue;
                }

                // all nodes inspected, exiting loop
                break;
            }

            return heightDictionary.Values.Max();
        }
    }

    public class Tree
    {
        public int x;
        public Tree l;
        public Tree r;
    };
}