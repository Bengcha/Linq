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
            newFunction.CarList();
            newFunction.StudentGradeAverage();
            Console.ReadKey();
        }
    }
}
