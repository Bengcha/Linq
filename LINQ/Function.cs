using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Function
    {
        public void CarList()
        {
            List<string> OldCarList = new List<string>();
            List<string> NewCarList;
            OldCarList.Add("GT-R");
            OldCarList.Add("Lamborghini");
            OldCarList.Add("Corvette");
            OldCarList.Add("Bugatti");
            OldCarList.Add("NSX");
            OldCarList.Add("GT-R");
            OldCarList.Add("Lamborghini");
            OldCarList.Add("Corvette");
            OldCarList.Add("Bugatti");
            OldCarList.Add("NSX");
            NewCarList = OldCarList.Distinct().ToList();
            foreach (string item in NewCarList)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(item);
                Console.ResetColor();
            }
        }
        public void StudentGradeAverage()
        {
            List<string> StudentGrade = new List<string>();
            List<int> GradeAverage = new List<int>(); 
            StudentGrade.Add("100,90,80,70,60,50");
            StudentGrade.Add("100,80,60,40,20,0");
            StudentGrade.Add("100,70,40,10,50,80");

            foreach (var gradeCalculation in StudentGrade)
            {
                List<int> StudentAveragGrade = new List<int>();
                string[] words = gradeCalculation.Split(',');
                foreach (string number in words)
                {
                    var staticNumber = int.Parse(number);
                    StudentAveragGrade.Add(staticNumber);
                }
                var MinGrade = (from d in StudentAveragGrade select d).Min();
                StudentAveragGrade.Remove(MinGrade);
                var StudentPersonalGradeCount = (from personalGrade in StudentAveragGrade select personalGrade).Count();
                var StudentGradeSum = (from personalGrade in StudentAveragGrade select personalGrade).Sum();
                var NewAverage = (StudentGradeSum / StudentPersonalGradeCount);
                GradeAverage.Add(NewAverage);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Students Average Grade: {0}", NewAverage);
                Console.ResetColor();
            }
            var StudentgradeCount = (from counting in GradeAverage select counting).Count();
            var ClassGradeOverAllSum = (from summing in GradeAverage select summing).Sum();
            var ClassGradeAverage = (ClassGradeOverAllSum / StudentgradeCount);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nClass Average Is: {0}", ClassGradeAverage);
            Console.ResetColor();
        }
        public void ReOrderStringOFLetter(string ReOrderString)      
        {
            string alphabetString;
            alphabetString = ReOrderString.ToLower();
            var display = 
                from letter in alphabetString
                orderby letter ascending
                group letter by letter into list
                select list;
            Console.WriteLine("elephant --->");
            foreach (var list in display)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("{0}{1}", list.Key, list.Count());
                Console.ResetColor();        
            }
        }
    }
}





