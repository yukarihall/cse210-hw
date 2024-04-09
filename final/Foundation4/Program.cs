using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Create list of activities
        List<Activity> activities = new List<Activity>();

        // Add activities
        activities.Add(new Running(DateTime.Now, 30, 3.0));
        activities.Add(new Cycling(DateTime.Now, 45, 15.0));
        activities.Add(new Swimming(DateTime.Now, 60, 20));

        // Display summary of each activity
        Console.WriteLine("Activity Summaries:");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
