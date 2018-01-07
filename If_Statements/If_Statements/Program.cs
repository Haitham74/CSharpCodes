using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int myVar = 10;
            if (myVar == 11)

                Console.WriteLine($"myVar equal to {myVar}");

            else
                Console.WriteLine($"myVar is NOT equal to 10");
            Console.ReadKey();
            */
            // _____******________*******__________*********


            /* 
            int myVar = 9;
            string myResult;

            if (myVar > 10)
            {
                myResult = "Greater than 10";
                Console.WriteLine(myResult);
            }
            if (myVar < 10)
            {
                myResult = "Less than 10";
                Console.WriteLine(myResult);
            }
            if (myVar == 10)
            {
                myResult = "Equal to 10";
                Console.WriteLine(myResult);
            }
                    Console.ReadKey();
                    */
            int myVar1 = 10, myVar2 = 5, myVar3 = 9;
            string myResult;

            if ((myVar1 <= 11) || (myVar2 == 5) && (myVar3 >= 8))
            {
                myResult = "True";
                Console.WriteLine(myResult);
            }       
            else
            {
                myResult = "False";
                Console.WriteLine(myResult);

            }
            Console.ReadKey();


        }
    }
}
