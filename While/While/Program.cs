using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double mySal = 1000.1, total = 0, TOT=0;
            while (i<10)
            {
                total += mySal;
                i++;
                TOT += total;
                Console.WriteLine("Salary number {0} is {1}",i,total);
            }
            Console. WriteLine("total is {0}", TOT);
            Console.ReadKey();
        }
    }
}
