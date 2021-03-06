﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Unit6exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise 1
            var namesList = new List<string>();
            while (true)
            {
                Console.Write("Enter a name: ");
                var nameInput = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(nameInput))
                    break;
                namesList.Add(nameInput);
            }

            if (namesList.Count > 3)
                Console.WriteLine("{0}, {1} and {2} others liked your post.", namesList[0],namesList[1], namesList.Count - 2 );
            else if (namesList.Count == 3)
                Console.WriteLine("{0} and {1} and other person liked your post.", namesList[0], namesList[1]);
            else if (namesList.Count == 2)
                Console.WriteLine("{0} and {1} liked your post.", namesList[0], namesList[1]);
            else if (namesList.Count == 1)
                Console.WriteLine("{0} liked your post.", namesList[0]);
            else
                Console.WriteLine();

            //exercise 2
            Console.Write("Enter a name: ");
            var input2 = Console.ReadLine();

            var nameArray2 = input2.ToCharArray();
            Array.Reverse(nameArray2);
            var reverseName = new String(nameArray2);
            Console.WriteLine(reverseName);

            //exercise 3
            var array3 = new List<int>();

            while (array3.Count < 5)
            {
                Console.WriteLine("Enter 5 numbers: ");
                var input3 = Convert.ToInt32(Console.ReadLine());

                if (array3.Contains(input3))
                {
                    Console.WriteLine("Not a unique number, try again");
                    continue;
                }
                array3.Add(input3);
            }
            Console.WriteLine();
            array3.Sort();
            foreach (var number in array3)
            {
                Console.WriteLine(number);
            }

            //exercise 4
            var numbers4 = new List<int>();

            while (true)
            {
                Console.Write("Enter a number or type Quit to exit: ");
                var input4 = Console.ReadLine();
                if (input4.ToLower() == "quit")
                    break;

                numbers4.Add(Convert.ToInt32(input4));
            }

            var uniqueNum = new List<int>();
            foreach (var number in numbers4)
            {
                if (!uniqueNum.Contains(number))
                {
                    uniqueNum.Add(number);
                }
            }

            Console.WriteLine("These are the unique numbers: ");
            foreach (var number in uniqueNum)
            {
                Console.WriteLine(number);
            }

            //exercise 5
            string[] elements;
            while (true)
            {
                Console.Write("Enter 5 or more comma separated numbers: ");
                var input5 = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input5))
                {
                    elements = input5.Split(',');
                    if (elements.Length >= 5)
                        break;
                }
                Console.WriteLine("Invalid list, please re-try.");
            }

            var numbers5 = new List<int>();
            foreach (var number in elements)
            {
                numbers5.Add(Convert.ToInt32(number));
            }

            var smallestNums = new List<int>();
            while (smallestNums.Count < 3)
            {
                var min = numbers5[0];
                foreach (var number in numbers5)
                {
                    if (number < min)
                        min = number;
                }
                smallestNums.Add(min);

                numbers5.Remove(min);
            }
            Console.WriteLine("The three smallest numbers: {0}, {1}, {2}", smallestNums[0], smallestNums[1], smallestNums[2]);
        }
    }
}
