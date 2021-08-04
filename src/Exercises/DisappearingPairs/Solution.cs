/*
DisappearingPairs
Reduce a string containing instances of the letters "A", "B" and "C" via the following rule: remove one occurrence of "AA", "BB" or "CC".
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

            char[] temp = new char[bufferLength];
            int tempLength;

            char firstCharacter, secondCharacter;

            S.CopyTo(0, buffer, 0, S.Length);

            int previousLength = 0;
            while (previousLength != bufferLength)
            {
                previousLength = bufferLength;

                tempLength = 0;

                // copying even characters
                for (int i = 0; i < bufferLength - 1; i += 2)
                {
                    firstCharacter = buffer[i];
                    secondCharacter = buffer[i + 1];

                    if ((firstCharacter != 'A' || secondCharacter != 'A') &&
                        (firstCharacter != 'B' || secondCharacter != 'B') &&
                        (firstCharacter != 'C' || secondCharacter != 'C'))
                    {
                        temp[tempLength++] = firstCharacter;
                        temp[tempLength++] = secondCharacter;
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
                    firstCharacter = buffer[i];
                    secondCharacter = buffer[i + 1];

                    if ((firstCharacter != 'A' || secondCharacter != 'A') &&
                        (firstCharacter != 'B' || secondCharacter != 'B') &&
                        (firstCharacter != 'C' || secondCharacter != 'C'))
                    {
                        temp[tempLength++] = firstCharacter;
                        temp[tempLength++] = secondCharacter;
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
