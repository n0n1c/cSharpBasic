using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpFundamentals.Math;

namespace cSharpFundamentals.person
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.firstName = "John";
            john.lastName = "Smith";
            john.Introduce();

            calculator calculator = new calculator();
            var result = calculator.add(1, 2);
            Console.WriteLine(result);
        }
    }
}
