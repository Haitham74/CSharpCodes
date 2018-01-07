using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_FloatPointTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;

            Console.WriteLine("Min value={0} Max value={1}", flMin, flMax);

            float flVar = 1f / 3;
            double DlVar = 1D / 3;
            decimal DcVar = 1M / 3;
            Console.WriteLine("\nfloat Value ={0}\ndouble Value ={1}\ndecimal Value ={2}", flVar, DlVar, DcVar);
            Console.ReadKey();


        }
    }
}
