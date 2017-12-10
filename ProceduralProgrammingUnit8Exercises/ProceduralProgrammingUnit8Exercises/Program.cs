using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgrammingUnit8Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        //exercise1
        public bool IsConsecutiveList(List<int> list)
        {
            var numbers = new int[list.Count];
            list.CopyTo(numbers);
            Array.Sort(numbers);

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                    return false;
            }
            return true;
        }

        //exercise2
        public bool ContainsDuplicate(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    return true;
                }
            }
            return false;
        }

        //exercise3
        public bool IsValidTime(string time)
        {
            if (String.IsNullOrWhiteSpace(time))
                return false;

            var components = time.Split(':');
            if (components.Length != 2)
                return false;

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minutes = Convert.ToInt32(components[1]);

                return (hour >= 0 && hour <= 23 && minutes >= 0 && minutes <= 59);
            }
            catch (Exception)
            {
                return false;
            }
        }

        //exercise4
        public string GetVariableName(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return "";

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }
            return variableName;
        }
    }
}
