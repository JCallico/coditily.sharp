/*
ParkingBill
Given two strings representing times of entry and exit from a car parking lot, find the cost of the ticket according to the given billing rules.

*/

using System;

namespace Callicode.Codility.Exercises.ParkingBill
{
    public class Solution
    {
        public int entranceFee { get; set; }  = 2;
        public int firstHourFee { get; set; } = 3;
        public int otherHourFee { get; set; } = 4;

        public int solution(String E, String L)
        {
            // use built-in parse functionality 
            // to find total minutes
            var timeE = DateTime.Parse(E);
            var timeL = DateTime.Parse(L);
            var totalMinutes = (timeL - timeE).TotalMinutes;

            if (totalMinutes <= 60)
            {
                // parked for one hour or less
                return entranceFee + firstHourFee;
            }

            // parked for longer than one hour
            return entranceFee + firstHourFee + (int)Math.Ceiling((totalMinutes - 60) / 60) * otherHourFee;
        }
    }
}