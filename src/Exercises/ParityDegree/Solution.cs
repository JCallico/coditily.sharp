/*
ParityDegree
Find the highest power of 2 that divides N.

*/

using System;

namespace Callicode.Codility.Exercises.ParityDegree
{
    public class Solution
    {
        public int solution(int N)
        {
            var result = 0;
            var index = 0;

            while (true)
            {
                var pow2 = Math.Pow(2, index);

                if (pow2 > N)
                {
                    break;
                }

                if (N % pow2 == 0)
                {
                    result = index;
                }

                index++;
            }

            return result;
        }
    }
}