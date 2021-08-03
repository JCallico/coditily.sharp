/*
DisappearingPairs
Reduce a string containing instances of the letters "A", "B" and "C" via the following rule: remove one occurrence of "AA", "BB" or "CC".
https://app.codility.com/programmers/trainings/5/disappearing_pairs/
*/

using System;

namespace Callicode.Codility.Exercises.DisappearingPairs
{
    public class Solution
    {
        public String solution(String S)
        {
            char[] buffer = new char[S.Length];
            int bufferLength = S.Length;

            char[] temp;
            int tempLength;

            int previousLength = 0;

            for (var i = 0; i < S.Length; i++)
            {
                buffer[i] = S[i];
            }

            while (previousLength != bufferLength)
            {
                previousLength = bufferLength;

                temp = new char[bufferLength];
                tempLength = 0;

                // copying even characters
                for (int i = 0; i < bufferLength - 1; i += 2)
                {
                    if ((buffer[i] != 'A' || buffer[i + 1] != 'A') &&
                        (buffer[i] != 'B' || buffer[i + 1] != 'B') &&
                        (buffer[i] != 'C' || buffer[i + 1] != 'C'))
                    {
                        temp[tempLength++] = buffer[i];
                        temp[tempLength++] = buffer[i + 1];
                    }
                }

                // copying last character
                if (bufferLength % 2 != 0)
                {
                    temp[tempLength++] = buffer[bufferLength - 1];
                }

                // avoid creating copy of temp buffer
                buffer = temp;
                bufferLength = tempLength;

                temp = new char[bufferLength];
                tempLength = 0;

                if (bufferLength < 2)
                {
                    continue;
                }

                // copying first character
                temp[tempLength++] = buffer[0];

                // copying odd characters
                for (int i = 1; i < bufferLength - 1; i += 2)
                {
                    if ((buffer[i] != 'A' || buffer[i + 1] != 'A') &&
                        (buffer[i] != 'B' || buffer[i + 1] != 'B') &&
                        (buffer[i] != 'C' || buffer[i + 1] != 'C'))
                    {
                        temp[tempLength++] = buffer[i];
                        temp[tempLength++] = buffer[i + 1];
                    }
                }

                // copying last character
                if (bufferLength % 2 == 0)
                {
                    temp[tempLength++] = buffer[bufferLength - 1];
                }

                // avoid creating copy of temp buffer
                buffer = temp;
                bufferLength = tempLength;
            }

            return new string(buffer, 0, bufferLength);
        }
    }
}
