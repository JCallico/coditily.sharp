/*
StrSymmetryPoint
Find a symmetry point of a string, if any.
https://app.codility.com/programmers/trainings/4/str_symmetry_point/
*/

using System;

namespace Callicode.Codility.Exercises.StrSymmetryPoint
{
    public class Solution
    {
        public int solution(String S)
        {
            int i;
            for (i = 0; i < S.Length - i && S[i] == S[S.Length -1 - i]; i++);

            return (i * 2) - 1 == S.Length ? i - 1 : -1;
        }
    }
}