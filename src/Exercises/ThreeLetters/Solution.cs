/*
ThreeLetters
Given two integers A and B, return a string which contains A letters "a" and B letters "b" with no three consecutive letters being the same.
*/

using System;
using System.Text;

namespace Callicode.Codility.Exercises.ThreeLetters
{
    public class Solution
    {
        public string solution(int A, int B)
        {
            var limit = 3;
            var temp = new StringBuilder();
            var forceA = false;

            while (A != 0 || B != 0)
            {
                // find the last N characters on current solution
                // where N is the max allowed consecutive characters of the same type
                var lastCharacters = temp.Length > limit - 1
                    ? temp.ToString(temp.Length - limit + 1, limit - 1)
                    : temp.ToString();

                // only execute if there are more A characters left
                // of if the previous cycle could not append more B characters
                if (A >= B || forceA)
                {
                    // resetting force flag
                    forceA = false;

                    // if more A characters can be appended then do so
                    if (A != 0 && lastCharacters != new string('a', limit - 1))
                    {
                        A = A - 1;
                        temp.Append('a');

                        continue;
                    }
                }

                // if more B characters can be appended then do so
                if (B != 0 && lastCharacters != new string('b', limit - 1))
                {
                    B = B - 1;
                    temp.Append('b');

                    continue;
                }

                // at this point no more B characters could be appended,
                // set the flag and force next cycle to append A characters
                forceA = true;
            }

            return temp.ToString();
        }
    }
}