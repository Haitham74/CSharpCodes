using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // + - / * %
            int myVar1 = 7;
            int myvar2 = 3;

            // Below are the FOUR simple operations
            int temp1 = myVar1 + myvar2;
            int Temp2 = myVar1 - myvar2;
            int temp3 = myvar2 * myVar1;

            //float flvar1 = myVar1 f/myvar2;

            int temp4 = myVar1 / myvar2;
            int temp5 = myVar1 % myvar2;
            int temp6 = temp5 / myvar2;
            int temp7 = temp4 + temp6;

            Console.WriteLine($"The addtion result is {temp1} \n\nThe subtraction results is {Temp2} \n\nThe multiplication results is {temp3} \n\nThe 7/3 is {temp4} \n\nThe remaining of division is {temp5} \n\nThe remaining divided by 3 is {temp6} \n\nThe division result is {temp7}");
            Console.ReadKey();
        }
    }
}
