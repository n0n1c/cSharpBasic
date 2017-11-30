using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit5exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            //exrecise 1
            var count = 0;
            for (var i = 1; i < 100; i++)
            {
                if ((i % 3) == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            //exercise 2 
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number or ok to exit: ");
                var input = Console.ReadLine();

                if (String.Equals(input, "ok"))
                {
                    Console.WriteLine(sum);
                    break;
                }
                else
                {
                    var convertedInt = Convert.ToInt32(input);
                    sum += convertedInt;
                    continue;
                }
            }

            //exercise 3
            Console.Write("Enter a number: ");
            var input2 = Console.ReadLine();
            var intedInput2 = Convert.ToInt32(input2);
            var sum2 = 1;
            for (var i = intedInput2; intedInput2 > 0; intedInput2--)
            {
                sum2 *= intedInput2;
            }
            Console.WriteLine("{0}! = {1}", input2, sum2);

            //exercise 4
            var randomNum = new Random().Next(1, 10);
            Console.WriteLine("The Secret number is " + randomNum);
            Console.WriteLine("You have 4 chances to guess the number between 1 and 10");

            for (var i = 0; i < 4; i++)
            {
                Console.Write("Guess the number: ");
                var guessedNum = Convert.ToInt32(Console.ReadLine());

                if (guessedNum == randomNum)
                {
                    Console.WriteLine("You won!");
                    return;
                }
                Console.WriteLine("Wrong number, fool!");
            }
            Console.WriteLine("You lost! Ha Ha Ha Ha");

            //exercise 5
            Console.Write("Enter a series of numbers separated by commas: ");
            var input5 = Console.ReadLine();

            var numbers5 = input5.Split(',');

            var max = Convert.ToInt32(numbers5[0]);

            foreach (var num in numbers5)
            {
                var number = Convert.ToInt32(num);
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine("Max is " + max);

        }
    }
}
