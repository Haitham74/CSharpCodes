using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_CharStringBoolTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = char.MinValue;
            int charMax = char.MaxValue;

            char myVar = 'G';
            int myVarValue = 'G';
            char myVarValue2 = Convert.ToChar(myVarValue);

            Console.WriteLine("Min char ={0} Max char ={1} My Char ={2} My Var Value ={3} my conversion value is = {4}", charMin, charMax, myVar, myVarValue, myVarValue2);
            
            string myString = "This is my Variable";
            Console.WriteLine("\nmy String {0}", myString);

            bool myBool = true;
            Console.WriteLine("\nMy boolean is {0}", myBool);
            Console.ReadKey();
        }
    }
}
