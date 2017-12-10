using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming1a
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (true)
            {

                Console.WriteLine("Enter a number(or quit to exit)");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = GetUniqueNumbers(numbers);
            
            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
            {
                Console.WriteLine(number);
            }
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }
            return uniques;
        }
    }

}
