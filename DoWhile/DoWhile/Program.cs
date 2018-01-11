using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            double mySalary = 1000.2, total = 0;
            int i = 0;
            do
            {
                total += mySalary; // total = total + mySalary
                i++;               // i = i + 1
                Console.WriteLine($"i = {i} total value is {total}"); // To print no. of month and the accumulated salary.

            } while (i < 10);
            Console.WriteLine($"TOTAL VALUE IS {total}");
            */

            double mySalary = 1020;
            int i = 0;
            do
            {
                mySalary += 20;

                i++;

             if (mySalary == 1980)
            
                Console.WriteLine($"At month {i} mySalary is {mySalary}, I will need {i / 12} years and {i % 12} month to reach that Salary");
            //else
            //Console.WriteLine($"Not Achieved");

            } while (i < 60);
            Console.ReadKey();
            

        }

    }
}
