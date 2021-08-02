/*
DisappearingPairs
Reduce a string containing instances of the letters "A", "B" and "C" via the following rule: remove one occurrence of "AA", "BB" or "CC".
https://app.codility.com/programmers/trainings/5/disappearing_pairs/
*/

using System;
using System.Collections.Generic;

class Solution
{
    public String solution(String S)
    {
        List<char> buffer = new List<char>(S);
        List<char> temp = new List<char>();
        var previousLength = 0;

        while (previousLength != buffer.Count)
        {
            previousLength = buffer.Count;

            // copying even characters
            for (int i = 0; i < buffer.Count - 1; i += 2)
            {
                if ((buffer[i] != 'A' || buffer[i + 1] != 'A') &&
                    (buffer[i] != 'B' || buffer[i + 1] != 'B') &&
                    (buffer[i] != 'C' || buffer[i + 1] != 'C'))
                {
                    temp.Add(buffer[i]);
                    temp.Add(buffer[i + 1]);
                }
            }

            // copying last character
            if (buffer.Count % 2 != 0)
            {
                temp.Add(buffer[buffer.Count - 1]);
            }

            buffer = temp;
            temp = new List<char>();

            if (buffer.Count < 2)
            {
                continue;
            }

            // copying first character
            temp.Add(buffer[0]);

            // copying odd characters
            for (int i = 1; i < buffer.Count - 1; i += 2)
            {
                if ((buffer[i] != 'A' || buffer[i + 1] != 'A') &&
                    (buffer[i] != 'B' || buffer[i + 1] != 'B') &&
                    (buffer[i] != 'C' || buffer[i + 1] != 'C'))
                {
                    temp.Add(buffer[i]);
                    temp.Add(buffer[i + 1]);
                }
            }

            // copying last character
            if (buffer.Count % 2 == 0)
            {
                temp.Add(buffer[buffer.Count - 1]);
            }

            buffer = temp;
            temp = new List<char>();
        }

        return new string(buffer.ToArray());
    }
}
