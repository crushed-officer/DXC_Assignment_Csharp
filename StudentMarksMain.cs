using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2AssignmentCsharp
{
    class StudentMarksMain
    {
        public static void Main()
        {
            StudentMarks m = new StudentMarks
            {
                RollNo = 007,
                Name = "Anirban",
                ClassName = 12,
                Semester = 8,
                Branch = "ECE",

            };
            m.Marks[0] = 80.0;
            m.Marks[1] = 58.0;
            m.Marks[2] = 92.0;
            m.Marks[3] = 78.0;
            m.Marks[4] = 55.0;

            m.Average = m.CalculateAverage();
            m.Result = m.PassFail();
            m.Display();
            
        }
    }
}
