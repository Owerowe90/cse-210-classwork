using System;
using System.Collections.Generic;

namespace goalz
{
    public class Goals
    {
        public List<GoalTemp> goal_list = new List<GoalTemp>();

        public void PrintGoalList()
        {
            Console.WriteLine("Goals List:");
            foreach (GoalTemp i in goal_list)
            {
                string goal = i.ConvertString();
                Console.WriteLine(goal);
            }
        }

        public virtual void GoalMenu() 
        {
            // List<String> temp_list;

            Console.Clear();
            Console.WriteLine("Goal Options:");
            Console.WriteLine(" ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Quit");
            Console.WriteLine(" ");
            Thread.Sleep(250);
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();
            Console.Clear();
            switch (choice)
            {
                
                case "1":
                    Console.WriteLine("Simple Goal:");
                    Console.WriteLine("");
                    Console.WriteLine("What is your goal?");
                    string goal_name = Console.ReadLine();
                    Console.WriteLine("Please write a short desc:");
                    string desc = Console.ReadLine();
                    Console.WriteLine("How many points for this goal?");
                    int points = Int32.Parse(Console.ReadLine());
                    Simple simp = new Simple(goal_name, desc, points);
                    
                    goal_list.Add(simp);
                    
                    
                    break;

                case "2":
                    // create an eternal goal
                    Console.WriteLine("Eternal Goal:");
                    Console.WriteLine("");
                    Console.WriteLine("What is your goal?");
                    string goal_name2 = Console.ReadLine();
                    Console.WriteLine("Please write a short desc:");
                    string desc2 = Console.ReadLine();
                    Console.WriteLine("How many points for this goal to be completed?");
                    int points2 = Int32.Parse(Console.ReadLine());
                    Eternal eter = new Eternal(goal_name2, desc2, points2);
                    
                    goal_list.Add(eter);

                    break;

                case "3":
                    // create a checklist goal
                    Console.WriteLine("Checklist Goal:");
                    Console.WriteLine("");
                    Console.WriteLine("What is your goal?");
                    string goal_name3 = Console.ReadLine();
                    Console.WriteLine("Please write a short desc:");
                    string desc3 = Console.ReadLine();
                    Console.WriteLine("How many times until this goal is completed? ");
                    int num_comp = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("How many points for this goal to be completed? ");
                    int points3 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("How many bonas points for each completion? ");
                    int xtra_points = Int32.Parse(Console.ReadLine());
                    Checklist check = new Checklist(goal_name3, desc3, points3, num_comp, xtra_points);

                    goal_list.Add(check);

                    break;
                
                case "4":
                    // quit
                    Console.WriteLine("Good-bye!");
                    Thread.Sleep(2000);  
                    break;
            }
        }
    }

}