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
                Console.WriteLine(item);
            }
        }

        public void StudentGradeAverage()
        {
            List<string> StudentGrade = new List<string>();
            List<int> GradeAverage = new List<int>(); 
            StudentGrade.Add("100,90,80,70,60,50");
            StudentGrade.Add("100,80,60,40,20,0");
            StudentGrade.Add("100,70,40,10,50,80");

            List<string> Grade = new List<string>();
            string[] value = StudentGrade.Split(',');





        }
    }
}





