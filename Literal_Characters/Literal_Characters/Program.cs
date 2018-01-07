using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar = 100;
            uint myUVar = 1000u;            // You can use (U) after the number or you do not need to

            float myflVar = 1.5f;          // You have to use (F) after the number, otherwise it will encounter an error
            double myDVar = 100.5D;       // You can use (D) after the number or you do not need to
            decimal myDecVar = 100.5M;    // You have to use (M) after the number, otherwise it will encounter an error

            Console.WriteLine("{0} {1}", myvar, myUVar);
            Console.WriteLine($"{myflVar} {myDVar} {myDecVar}");
            Console.ReadKey();

        }
    }
}
