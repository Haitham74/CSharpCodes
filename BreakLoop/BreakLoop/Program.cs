using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i <=8; i++)
            {
                Console.WriteLine($"Hello Mustafa");
                if (i >= 3)
                    break;
                for (int j = 0; j <= 5; j++)
                {
                    Console.WriteLine($"\t Eat Lover");
                }
                Console.WriteLine($"\n");
            }Console.ReadKey();
            */
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Multiplication table {i}");
               // if (i == 7)
                 //   break;
                for (int j = 1; j <11; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                } Console.WriteLine($"\n");
            } Console.ReadKey();
        }
    }
}
