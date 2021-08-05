/*
ArrayInversionCount
Compute number of inversion in an array.
*/

namespace Callicode.Codility.Exercises.ArrayInversionCount
{
    public class Solution
    {
        public int solution(int[] A)
        {
            var inversionCount = 0;

            for (var p = 0; p < A.Length - 1; p++)
            {
                for (var q = p + 1; q < A.Length; q++)
                {
                    if (A[q] < A[p])
                    {
                        inversionCount++;

                        if (inversionCount > 1000000000)
                        {
                            return -1;
                        }
                    }
                }
            }

            return inversionCount;
        }
    }
}
