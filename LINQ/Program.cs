using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Function newFunction = new Function();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Returning a Copy of List Without Deplication");
            Console.ResetColor();
            newFunction.CarList();
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("\nShow Student Average Grade and Class Room Overall Grade");
            Console.ResetColor();
            newFunction.StudentGradeAverage();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nFunction that Return a String in Alphabetically Order");
            Console.ResetColor();
            newFunction.ReOrderStringOFLetter("elephant");
            //string alphabet = newFunction.ReOrderStringOFLetter("elephant");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("elephant ---> {0}", alphabet);
            //Console.ResetColor();
            Console.ReadKey();
        }
    }
}
