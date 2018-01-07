using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int mySal = 1000, mysal2= 1000, total2=0, total = 0;
            for (int i=1 ; i<=15; i=i+2)
            {
                total =(mySal*i);

                Console.WriteLine($"{i} {total}");
             }
          /*  for (int j = 0; j < 15; j=j+2)
            {
                total2 += mysal2;
                Console.WriteLine($"\n{j} {total2}");
            }
            */
                Console.ReadKey();
        }
    }
}
