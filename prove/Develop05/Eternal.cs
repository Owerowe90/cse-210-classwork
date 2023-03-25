using System;
using System.Collections.Generic;

namespace goalz
{
    public class Eternal : GoalTemp
    {
        string goal_string;
        
        public Eternal(string goal_name, string desc, int points) : base (goal_name, desc, points)
        {
            
        }

        public override string ConvertString()
        {
            goal_string = $"{base._complete} | {base._goal_name} - {base._desc}";
            return goal_string;
        }



    }
}