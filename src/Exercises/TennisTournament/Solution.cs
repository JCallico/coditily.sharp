/*
TennisTournament
Given the number of players P and the number of reserved courts C, 
returns the maximum number of games that can be played in parallel.
*/

using System;
using System.Text;

namespace Callicode.Codility.Exercises.TennisTournament
{
    public class Solution
    {
        public int solution(int P, int C)
        {
            // Games must be played between two players
            var maxGamesByPlayers = P / 2;

            // The maximum number of games that can be played in parallel 
            // is limited by the number of courts
            var maxGamesByCourts = C;
            
            // The result is the minimum of the two constraints
            return Math.Min(maxGamesByPlayers, maxGamesByCourts);
        }
    }
}