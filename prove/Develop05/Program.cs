using System;
using System.Collections.Generic;

namespace goalz
{
class Program
{
    static void Main(string[] args)
    {
        Goals goal = new Goals();
        while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine(" ");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Enter Progress");
                Console.WriteLine("6. Quit");
                Console.WriteLine(" ");
                Thread.Sleep(250);
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        // create a new goal
                        goal.GoalMenu();
                        break;

                    case "2":
                        // view list goals
                        goal.PrintGoalList();
                        Thread.Sleep(2000);

                        break;

                    case "3":
                        // // save goals
                        // Console.WriteLine("What would you like to name the file?");
                        // string file_name = Console.ReadLine();
                        // Build_Goals.getGoals(file_name);
                        break;

                    case "4":
                        // // load goals
                        // Console.WriteLine("What Journal file would you like to access?");


                        // string filename = Console.ReadLine();
                        // string[] load_goals = System.IO.File.ReadAllLines(filename);
                        // Build_Goals.loadGoals(load_goals);
                        break;
                    
                    case "5":
                        // enter progress

                        break;

                    case "6":
                        // quit
                        Console.WriteLine("Goodjob Setting goals!");
                        Thread.Sleep(1000);
                        Environment.Exit(0);    
                        break;
                        
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Thread.Sleep(2000);
                        break;
                }
            }
    }
}
}