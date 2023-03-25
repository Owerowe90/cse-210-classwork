using System;
using System.Collections.Generic;

namespace goalz
{
    public abstract class GoalTemp
    {
        public string _goal_name;
        public string _desc;
        public int _points;
        public int _num_comp;
        public bool _complete;
        public int _xtra_points;

        public GoalTemp(string goal_name, string desc, int points, int num_comp, int xtra_points)
        {
            _goal_name = goal_name;
            _desc = desc;
            _points = points;
            _num_comp = num_comp;
            _xtra_points = xtra_points;
            _complete = false;
        }

        public abstract string ConvertString();

    }
}