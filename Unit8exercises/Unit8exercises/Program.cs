using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit8exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few numbers separated by hyphens: ");
            var input1 = Console.ReadLine();

            var numbers1 = new List<int>();
            foreach (var number in input1.Split('-'))
            {
                numbers1.Add(Convert.ToInt32(number));
            }

            numbers1.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers1.Count; i++)
            {
                if (numbers1[i] != numbers1[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecuive" : "Not Consecutive";
            Console.WriteLine(message);

            //Exercise 2

            //Console.Write("Enter a few hyphen separated numbers: ");
            //var input2 = Console.ReadLine();

            //if (String.IsNullOrWhiteSpace(input2))
            //    return;

            //var numbers2 = new List<int>();
            //foreach (var number in input2.Split('-'))
            //    numbers2.Add(Convert.ToInt32(number));
            
            //var uniqueNums = new List<int>();
            //var isDuplicate = false;
            //foreach (var number in numbers2)
            //{
            //    if (!uniqueNums.Contains(number))
            //        uniqueNums.Add(number);
            //    else
            //    {
            //        isDuplicate = true;
            //        break;
            //    }
            //}

            //if (isDuplicate)
            //    Console.WriteLine("Duplicate");
            //exercise 3

            Console.Write("Enter a 24 hour time value (e.g. 23.59): ");
            var input3 = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input3))
            {
                Console.WriteLine("Invalid time!");
                return;
            }
            var components = input3.Split();
            if (components.Length > 2)
            {
                Console.WriteLine("Invalid time!");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minutes = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minutes >= 0 && minutes <= 59)
                    Console.WriteLine("OK");
                else Console.WriteLine("Invalid time!");
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid time!");
            }
        }
    }
}
