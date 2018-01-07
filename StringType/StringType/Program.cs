using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            // \' \" \\ \0 \a \b \n \r \t \v \f
            // @
            string myString = "This is\'MY STRING\'varaible";   // To SHOW '    '
            string myString1 = "This is\"MY STRING\"variable";  // To SHOW "    "
            string myString2 = "This is\\MY STRING\\variable";  // To SHOW \   \
            string myString3 = "This is MY STRING variable\0";  // To announce the end of the STRING
            string myString4 = "This is MY STRING variable\a";  // To MAKE a sound
            string myString5 = "This is\b MY STRING variable";  // To DELETE last letter before \b BUT it does not work at the end of the phrase
            string myString6 = "This is MY STRING \nvariable";  // To ADD split the phrase into Two lines. You can add another one to drop it more
            string myString7 = "This is MY\r STRING variable";   // To DELETE everything before it. BUT it does not work after the 13 letters
            string myString8 = "This\t is MY STRING variable";  // To leave a space after IT (space equale to (about) same word after IT)
            string myString9 = "This\v is MY STRING variable";  // To leave (?) at that place 
            string myString10 = "This\f is MY STRING variable"; // To leave (?) at that place (same as \v)??
            string myString11 = @"This is \MY STRING\ 
            variable";                                    // To eliminate errors and make TWO continouing lines one below the other 
            string myString12 = myString1 + myString2;

            string myString13 = "This is";
            string mystring133 = "\"";
            string myString14 = "MY STRING";
            string myString144 = "\"";
            string myString15 = "varaible";
            string myString16 = myString13 +mystring133 + myString14 + myString144 +myString15;

            Console.WriteLine($"{myString} \n\n{myString1} \n\n{myString2} \n\n{myString3} \n\n{myString4} \n\n{myString5} \n\n{myString6} \n\n{myString7} \n\n{myString8} \n\n{myString9} \n\n{myString10} \n\n{myString11} \n\n{myString12} \n\n{myString16}");
            Console.ReadKey();

            
        }
    }
}
