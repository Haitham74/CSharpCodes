using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            /*=======================USING INTERGER============
            int myVar = 9;
            string myResult = (myVar < 8) ? "Less than 8" : "Greater than 8";
            Console.WriteLine($"my VarResult is {myResult}");
            */
           
            // ====================USING STRING================
            string myName = "Haitham", result;
            result = (myName.Equals("Haitham")) ? "YES" : "NO";
            Console.WriteLine($"my Variable rsult is {result}");
            Console.ReadKey();
        }
        
    }
}
