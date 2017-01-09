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
            Console.WriteLine("Returning Copy of List Without Deplicates");
            Console.ResetColor();
            newFunction.CarList();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nShow Student Average Grade and Class Room Overall Grade");
            Console.ResetColor();
            newFunction.StudentGradeAverage();
            Console.ReadKey();
        }
    }
}
