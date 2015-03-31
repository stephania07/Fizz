using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz
{
    class Program
    {
        static void Main(string[] args)
        {

            for (var i = 1; i <= 100; i++)
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }

                    else
                    {
                        Console.WriteLine("Fizz");

                    }
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
         
                Console.ReadKey();
        }
    }
}
