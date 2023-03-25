using System;
using System.Collections.Generic;

namespace goalz
{
    class Checklist : GoalTemp
    {
        string goal_string;
        
        public Checklist(string goal_name, string desc, int points, int num_comp, int xtra_points) : base (goal_name, desc, points, num_comp, xtra_points)
        {
            
        }

        public override string ConvertString()
        {
            goal_string = $"{base._complete} | {base._goal_name} - {base._desc} | {base._num_comp}";
            return goal_string;
        }


    }
}