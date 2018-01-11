using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ==============================================General Example==================================
             for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"They said \"Hello Haitham\"");
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"\t I replied \"Hello World\"");
                } Console.WriteLine($"\n");
            } Console.ReadKey();
            */

            /*===============================Multiplication Table from 1 - 5=======================================
          for (int i = 1; i < 6; i++)
            {
              for (int j = 1; j < 11; j++)
              Console.WriteLine($"{i} X {j} = {i * j}");
            }Console.ReadKey();
           */

            /* ==============================Multiplication table from 1 - 6 EVEN Numbers================
              for (int i = 0; i < 7; i +=2)
                {
                  for (int j = 1; j < 11; j++)
                 Console.WriteLine($"{i} X {j} = {i * j}");
                 }
                   Console.ReadKey();
             */

            // ===============================Multiplication table from 1 - 6 ODD Numbers================
            for (int i = 1; i < 7; i += 2)
            {
                for (int j = 1; j < 11; j++)
                    Console.WriteLine($"{i} X {j} = {i * j}");
            }
            Console.ReadKey();
        }
    }
}
