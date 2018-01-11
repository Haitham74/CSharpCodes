using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakLoop_ContinueCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <=4; i++)
            {
                Console.WriteLine($"Hello Haitham");
                if (i > 2)
                    continue;  // This will make the internal loop achived AS LONG AS the i < 2. 
                               // If i become > 2 it will not consider the internal loop and jump to continue the external loop
                for (int j = 0; j<=2; j++)
                {
                    Console.WriteLine($"\t Hello World");
                }
                //Console.WriteLine($"Hello Haitham");
                Console.WriteLine($"\n");
            }Console.ReadKey();
        }
    }
}
