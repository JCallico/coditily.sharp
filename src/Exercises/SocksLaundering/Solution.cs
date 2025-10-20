/*
SocksLaundering
Bob is about to go on a trip. But first he needs to take care of his supply of socks. Each sock has its own color. Bob wants to take as many pairs of clean socks as possible (both socks in the pair should be of the same color).

Socks are divided into two drawers: clean and dirty socks. Bob has time for only one laundry and his washing machine can clean at most K socks. He wants to pick socks for laundering in such a way that after washing he will have a maximal number of clean, same-colored pairs of socks. It is possible that some socks cannot be paired with any other sock, because Bob may have lost some socks over the years.

Bob has exactly N clean and M dirty socks, which are described in arrays C and D, respectively. The colors of the socks are represented as integers (equal numbers representing identical colors).

If Bob's washing machine can clean at most K = 2 socks, then he can take a maximum of three pairs of clean socks. He can wash one red sock and one green sock, numbered 1 and 2 respectively. Then he will have two pairs of red socks and one pair of green socks.

Given an integer K (the number of socks that the washing machine can clean), two arrays C and D (containing the color representations of N clean and M dirty socks respectively), returns the maximum number of pairs of socks that Bob can take on the trip.

Assume that:
K is an integer within the range [1..50]
Each element of arrays C and D is an integer within the range [1..50]
C and D are not empty and each of them contains at most 50 elements
*/

using System;
using System.Collections.Generic;

namespace Callicode.Codility.Exercises.SocksLaundering
{
    public class Solution
    {
        public int solution(int K, int[] C, int[] D)
        {
            // Track remaining washing capacity
            var numberOfSocksMachineCanWash = K;
            var pairsToTakeOnTrip = 0;
            
            // Step 1: Count occurrences of each color in clean socks
            var matchingColorsInClean = new Dictionary<int, int>();

            foreach (var color in C)
            {
                // Count each color occurrence in clean socks
                matchingColorsInClean[color] = (matchingColorsInClean.ContainsKey(color) ? matchingColorsInClean[color] : 0) + 1;
            }

            // Step 2: Count existing pairs from clean socks and track single socks
            foreach (var color in matchingColorsInClean.Keys)
            {
                // Add complete pairs from clean socks (e.g., 5 socks = 2 pairs + 1 single)
                pairsToTakeOnTrip += matchingColorsInClean[color] / 2;
                // Keep only the remainder (single socks that need a match)
                matchingColorsInClean[color] = matchingColorsInClean[color] % 2;
            }

            // After this point, matchingColorsInClean contains only colors with 1 sock each, 
            // otherwise it would have been counted as a pair and reduced to 0

            // Step 3: Count occurrences of each color in dirty socks
            var matchingColorsInDirty = new Dictionary<int, int>();

            foreach (var color in D)
            {
                // Count each color occurrence in dirty socks
                matchingColorsInDirty[color] = (matchingColorsInDirty.ContainsKey(color) ? matchingColorsInDirty[color] : 0) + 1;
            }

            // Step 4: Priority strategy - wash single dirty socks to match clean singles
            // This is more efficient than washing pairs of dirty socks
            foreach (var color in matchingColorsInDirty.Keys)
            {
                // Stop if washing machine is full
                if (numberOfSocksMachineCanWash == 0)
                {
                    break;
                }

                // If there's a single clean sock of this color waiting for a match
                if (matchingColorsInClean.TryGetValue(color, out int cleanCount) && cleanCount != 0)
                {
                    // Wash one dirty sock to create a pair with the clean single
                    matchingColorsInDirty[color] -= 1;
                    numberOfSocksMachineCanWash -= 1;
                    pairsToTakeOnTrip += 1;
                }
            }

            // If less than 2 washing slots remain, we can't wash any more pairs
            if (numberOfSocksMachineCanWash < 2)
            {
                return pairsToTakeOnTrip;
            }

            // Step 5: Wash complete pairs from dirty socks
            // After washing all possible singles, use remaining capacity for dirty pairs
            foreach (var color in matchingColorsInDirty.Keys)
            {
                // Need at least 2 slots to wash a pair
                if (numberOfSocksMachineCanWash < 2)
                {
                    break;
                }

                // Calculate how many complete pairs of this color are available in dirty socks
                var dirtyPairsOfThisColor = matchingColorsInDirty.TryGetValue(color, out int dirtyCount) ? dirtyCount / 2 : 0;
                if (dirtyPairsOfThisColor == 0)
                {
                    continue; // No pairs of this color to wash
                }

                // Determine how many pairs we can actually wash (limited by capacity or availability)
                var dirtyPairsThatCanbeWashedOfThisColor = Math.Min(numberOfSocksMachineCanWash / 2, dirtyPairsOfThisColor);

                // Add the pairs and reduce washing capacity
                pairsToTakeOnTrip += dirtyPairsThatCanbeWashedOfThisColor;
                numberOfSocksMachineCanWash -= dirtyPairsThatCanbeWashedOfThisColor * 2;
            }

            return pairsToTakeOnTrip;
        }
    }
}