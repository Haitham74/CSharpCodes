using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 9, myVar2 = 7;

            if (myVar1 == 9)
            {
                Console.WriteLine($"myVar1 equal to 9");
                if (myVar2 ==6)
                {
                    Console.WriteLine($"myVar2 equal to 7");
                }
                else
                {
                    Console.WriteLine($"myVar2 IS NOT equal to 7");
                }
            }
            else
            {
                Console.WriteLine($"myVar1 IS NOT equal to 9");
            }
            Console.ReadKey();
        }
    }
}
