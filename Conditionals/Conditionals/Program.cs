using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got a promotion.");
                    break;

                default:
                    Console.WriteLine("I don't understand that season.");
                    break;
            }
        }
    }
}
