/*
DisappearingPairs
Reduce a string containing instances of the letters "A", "B" and "C" via the following rule: remove one occurrence of "AA", "BB" or "CC".
https://app.codility.com/programmers/trainings/5/disappearing_pairs/
*/

using System;
using System.Text;

namespace Callicode.Codility.Exercises.DisappearingPairsSimple
{
    public class Solution
    {
        public string[] disappearingPairs = {"AA", "BB", "CC"};

        public String solution(String S)
        {
            var answer = new StringBuilder(S);
            var previousLength = 0;

            // keep iterating until no change is made
            while (previousLength != answer.Length)
            {
                previousLength = answer.Length;

                foreach (var pair in disappearingPairs)
                {
                    answer.Replace(pair, string.Empty);
                }
            }

            return answer.ToString();
        }
    }
}
