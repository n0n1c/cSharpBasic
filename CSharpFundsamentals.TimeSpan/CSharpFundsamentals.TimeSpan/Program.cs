using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundsamentals.TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Timespan
            var timeSpan = new System.TimeSpan(1, 2, 3);
            var timeSpan1 = new System.TimeSpan(1, 0, 0);
            var timeSpan2 = System.TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add Example: " + timeSpan.Add(System.TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(System.TimeSpan.FromMinutes(2)));

            // ToString
            Console.WriteLine("ToString " + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse: " + System.TimeSpan.Parse("01:02:03"));
        }
    }
}
