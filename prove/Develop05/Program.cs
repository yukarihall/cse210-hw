using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
       while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Creat New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            GoalManager goalManager = new GoalManager();
            switch (choice)
            {
                case "1": //Creat New Goal
                    goalManager.Start();
                    break;
                case "2": //List Goals
                    goalManager.ListGoalNames();
                    break;
                case "3": //Save Goals
                    goalManager.SaveGoals();
                    break;
                case "4": //Load Goals
                    goalManager.LoadGoals();
                    break;
                case "5": //Record Event
                    goalManager.RecordEvent();
                    break;
                case "6": //Quit
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }       
    }
}