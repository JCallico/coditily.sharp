/*
ArrayInversionCount
Compute number of inversion in an array.
All credit goes to: https://www.geeksforgeeks.org/counting-inversions/
*/

namespace Callicode.Codility.Exercises.ArrayInversionCount
{
    public class Solution
    {
        private int maxInversions = 1000000000;

        public int solution(int[] A)
        {
            int[] temp = new int[A.Length];
            return CountInversionsUsingMergeSort(A, temp, 0, A.Length - 1);
        }

        private int CountInversionsUsingMergeSort(int[] array, int[] tempArray, int left, int right)
        {
            int inversionsCount = 0;

            if (right > left)
            {
                var middle = (right + left) / 2;

                inversionsCount += CountInversionsUsingMergeSort(array, tempArray, left, middle);
                if (inversionsCount < maxInversions)
                {
                    inversionsCount += CountInversionsUsingMergeSort(array, tempArray, middle + 1, right);
                }

                if (inversionsCount < maxInversions)
                {
                    inversionsCount += Merge(array, tempArray, left, middle + 1, right);
                }
            }

            return inversionsCount <= maxInversions ? inversionsCount : -1;
        }

        private int Merge(int[] array, int[] tempArray, int startLeftIndex, int startMiddleIndex, int startRightIndex)
        {
            int inversionsCount = 0;

            var leftIndex = startLeftIndex;
            var rightIndex = startMiddleIndex;
            var mergedIndex = startLeftIndex;
            
            while ((leftIndex <= startMiddleIndex - 1) && (rightIndex <= startRightIndex))
            {
                if (array[leftIndex] <= array[rightIndex])
                {
                    tempArray[mergedIndex++] = array[leftIndex++];
                }
                else
                {
                    tempArray[mergedIndex++] = array[rightIndex++];
                    inversionsCount = inversionsCount + (startMiddleIndex - leftIndex);
                }
            }

            while (leftIndex <= startMiddleIndex - 1)
            {
                tempArray[mergedIndex++] = array[leftIndex++];
            }

            while (rightIndex <= startRightIndex)
            {
                tempArray[mergedIndex++] = array[rightIndex++];
            }

            for (leftIndex = startLeftIndex; leftIndex <= startRightIndex; leftIndex++)
            {
                array[leftIndex] = tempArray[leftIndex];
            }

            return inversionsCount;
        }
    }
}
