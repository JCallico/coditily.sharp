/*
DisappearingPairs
Reduce a string containing instances of the letters "A", "B" and "C" via the following rule: remove one occurrence of "AA", "BB" or "CC".
https://app.codility.com/programmers/trainings/5/disappearing_pairs/
*/

using System;

class Solution
{
    public string[] disappearingPairs = { "AA", "BB", "CC" };

    public String solution(String S)
    {
        char[] buffer = new char[S.Length];
        char[] temp = new char[S.Length];
        var previousLength = 0;
        var newLength = 0;

        for (var i = 0; i < S.Length; i++)
        {
            buffer[i] = S[i];
        }

        while (previousLength != buffer.Length)
        {
            previousLength = buffer.Length;
            newLength = 0;

            temp = new char[buffer.Length];

            // copying even characters
            for (int i = 0; i < buffer.Length - 1; i += 2)
            {
                if ((buffer[i] != 'A' || buffer[i + 1] != 'A') &&
                    (buffer[i] != 'B' || buffer[i + 1] != 'B') &&
                    (buffer[i] != 'C' || buffer[i + 1] != 'C'))
                {
                    temp[newLength++] = buffer[i];
                    temp[newLength++] = buffer[i + 1];
                }
            }

            // copying last character
            if (buffer.Length % 2 != 0)
            {
                temp[newLength++] = buffer[buffer.Length - 1];
            }

            buffer = new char[newLength];
            Array.Copy(temp, buffer, newLength);

            temp = new char[buffer.Length];

            // resetting new length counter
            newLength = 0;

            if (buffer.Length < 2)
            {
                continue;
            }

            // copying first character
            temp[0] = buffer[0];

            newLength++;

            // copying odd characters
            for (int i = 1; i < buffer.Length - 1; i += 2)
            {
                if ((buffer[i] != 'A' || buffer[i + 1] != 'A') &&
                    (buffer[i] != 'B' || buffer[i + 1] != 'B') &&
                    (buffer[i] != 'C' || buffer[i + 1] != 'C'))
                {
                    temp[newLength++] = buffer[i];
                    temp[newLength++] = buffer[i + 1];
                }
            }

            // copying last character
            if (buffer.Length % 2 == 0)
            {
                temp[newLength++] = buffer[buffer.Length - 1];
            }

            buffer = new char[newLength];
            Array.Copy(temp, buffer, newLength);
        }

        return new string(buffer);
    }
}
