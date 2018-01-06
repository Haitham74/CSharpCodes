using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean Comparison ==  ,  != ,   <   ,    >   ,  <=   ,   >=
            // Boolean Condition  &&   ,    ||  These are conditions meaning (&& = and .....|| = OR)
            bool myRes1, myRes2, myRes3, myRes, myRes4, myRes5, myRes6, myRes7;
            int myVar1 = 5, myVar2 = 8;
            myRes1 = myVar1 == 6; // We are asking the compiler (Is the value myVar1 (=5) equal to 6?) It should be FALSE.
            myRes2 = myVar1 == 5; // We are asking the compiler (Is the value myVar1 (=5) equal to 5?) It should be TRUE.
            myRes3 = myVar1 != 5; // We are asking the compiler (Is the value myVar1 (=5) Does not equal to 5?) It should be FALSE.
            myRes4 = myVar2 < 9; //We are asking the compiler(Is the value myVar2(= 8 smaller than 9?) It should be TRUE.
            myRes5 = myVar2 >= 9; //We are asking the compiler(Is the value myVar2(= 8 Bigger or equal to 9?) It should be FALSE.
            myRes6 = (myVar1 == 5) && (myVar2 >= 6); // Asking the compiler to achive TWO conditions to make the statement TRUE.
            myRes7 = (myVar1 >= 4) || (myVar2 == 8); // Asking the compiler to achive any conditio (EITHER OR) to make the statement TRUE.


            Console.WriteLine($"{myRes1} \n\n{myRes2} \n\n {myRes3} \n\n {myRes4} \n\n{myRes5} \n\n{myRes6} \n\n{myRes7}");
            Console.ReadKey();
        }
    }
}
