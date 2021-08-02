/*
ThreeLetters (solved using recursive approach, score: 46)
Given two integers A and B, return a string which contains A letters "a" and B letters "b" with no three consecutive letters being the same.
https://app.codility.com/programmers/trainings/5/three_letters/
*/

using System;

class Solution
{
    public string solution(int A, int B)
    {
        return solutionRecursive(A, B, string.Empty, 3);
    }

    private string solutionRecursive(int a, int b, string temp, int limit)
    {
        if (temp == null)
        {
            temp = string.Empty;
        }

        if (a == 0 && b == 0)
        {
            // nothing to do, the end has been reached
            return temp;
        }

        // get last n-1 characters
        var lastCharacters = temp.Length > limit - 1 ? temp.Substring(temp.Length - limit + 1) : temp;

        if (a != 0 && lastCharacters != new string('a', limit - 1))
        {
            // an 'a' can be added to the end of the temp string:
            // trying adding 'b' to the end
            var result = solutionRecursive(a - 1, b, temp + 'a', limit);

            // return only if a viable solution was found using this path
            if (result != null)
            {
                return result;
            }
        }

        // at this point either there are no more 'a' characters to be added
        // or adding an 'a' didn't return a viable solution:
        // trying adding 'b' to the end
        if (b != 0 && lastCharacters != new string('b', limit - 1))
        {
            return solutionRecursive(a, b - 1, temp + 'b', limit);
        }

        return null;
    }
}
