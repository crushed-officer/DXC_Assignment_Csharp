using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2AssignmentCsharp
{
    class StudentMain
    {
        public static void Main()
        {
            Student s1 = new Student()
            {
                RollNo = 1160,
                StudName = "Anirban",
                MarksEng = 95,
                MarksMath = 92,
                MarksScience = 90
            };
            s1.CalculatePercentage();
            s1.Display();
            Console.ReadKey();
        }
    }
}
