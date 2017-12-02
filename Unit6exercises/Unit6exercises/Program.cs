using System;
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

        }
    }
}
