using System;
using System.Collections.Generic;

namespace goalz
{
    public class Score
    {
        public int TotalPoints;

        public void AddPoints(int points)
        {
            TotalPoints += points;
        }
    }
}