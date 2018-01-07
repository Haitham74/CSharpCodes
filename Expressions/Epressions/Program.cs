using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epressions
{
    class Program
    {
        static void Main(string[] args)
        {
            float myVar = 10.5f;          // The (myVar = 10.5;) called "Operand
            float myVar2 = 10.7f;         // The (myVar2 = 10.7;) called "Operand
            float temp = myVar + myVar2;  // the word (temp) mean temperoray. The (temp = myVar + myVar2;) called EXPRESSION and (+) is the Operator

            // Simple Operators are (+, -, /, *) and called unary operators
            // More comlicated called Binary operands such as (Bitwise operations). Mainly used
            // More complicated calle the logical operands such as the Boolean (true and false), triple 

            Console.WriteLine($"{myVar} \n\n{myVar2}");
            Console.ReadKey();
            
        }
    }
}
