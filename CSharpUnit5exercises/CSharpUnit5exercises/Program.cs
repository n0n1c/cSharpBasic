using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUnit5exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise1
            Console.Write("Enter a number between 1 and 10: ");
            var input1 = Console.ReadLine();
            var number1 = Convert.ToInt32(input1);

            if (number1 > 1 && number1 < 10)
            {
               Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //exercise2
            Console.Write("Enter a number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            var input2a = Convert.ToInt32(Console.ReadLine());
            var max = (input2 > input2a) ? input2 : input2a;
            Console.WriteLine("Max is " + max);

            //exercise3
            Console.Write("Enter a height of image: ");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a width of image: ");
            var width = Convert.ToInt32(Console.ReadLine());
            var orientation = (height > width) ? height : width;
            if (orientation == height)
            {
                Console.WriteLine("Your image has a portrait orientation.");
            }
            else
            {
                Console.WriteLine("Your image has a landscape orientation");
            }

            //exercise4
            Console.Write("Enter a speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your speed of travel: ");
            var travelSpeed = Convert.ToInt32(Console.ReadLine());
            var demeritPoints = (travelSpeed - speedLimit) / 5;

            if (speedLimit > travelSpeed)
            {
                Console.WriteLine("OK");
            }
            else if (demeritPoints > 12)
            {
                Console.WriteLine("Your license is suspended!");
            }
            else
            {
                Console.WriteLine("You have incurred {0} demerit points", demeritPoints);
            }
        }
    }
}
