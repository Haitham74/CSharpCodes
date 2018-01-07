using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increments__Decrements_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 7;
            int myVar2 = 2;
            int temp1 = myVar1-- / ++myVar2;
            //int temp1 = ++myVar1;
            
       
            Console.WriteLine($"{temp1}");
            Console.ReadKey();
        }
    }
}
