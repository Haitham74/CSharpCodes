using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
          // ===========================USING STRING============================
            /*string myAnimal = "Cat";
            switch (myAnimal)
            {
                case "Canary":
                Console.Write($"my Animal is the CANARY");
                    break;
                case "Cat":
                    Console.Write($"my Animal is the CAT");
                    break;
                case "Camel":
                    Console.Write($"my Animal is the CAMEL");
                    break;

                default:
                    Console.Write($"No one");
                    break;
            */
            //===========================USING INTEGER====================================
                int myVar = 15;
                switch (myVar)
                {
                    case 10:
                        Console.Write($"my Variable is 10");
                        break;
                    case 15:
                        Console.Write($"my Variable is 15");
                        break;
                    case 7:
                        Console.Write($"my Variable is 7");
                        break;

                    default:
                        Console.Write($"No one");
                        break;
                }
                Console.ReadKey();
                
                //==============================THE CHALLANGE=============================================
                // I did not apply the challange because it is not worth it. 

        }
    }
}
