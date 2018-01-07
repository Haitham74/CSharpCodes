using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 4, b = 3;
            double d = a / b;

            int myVar1 = 4, myVar2 = 3, myVar;
            myVar = (myVar1 / myVar2);

            Console.WriteLine($" My division result using DOUBLE is = {d}, \n\nMy division result using INT is = {myVar}");
            Console.ReadKey();
        }
    }
}
