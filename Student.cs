using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2AssignmentCsharp
{
    class Student
    {
        private int rollNo;
        private string studName;
        private int marksEng;
        private int marksMath;
        private int marksScience;
        private int percentage;

        public int RollNo { get => rollNo; set => rollNo = value; }
        public string StudName { get => studName; set => studName = value; }
        public int MarksEng { get => marksEng; set => marksEng = value; }
        public int MarksMath { get => marksMath; set => marksMath = value; }
        public int MarksScience { get => marksScience; set => marksScience = value; }
        public int Percentage { get => percentage; set => percentage = value; }

        public int CalculatePercentage()
        {
            Percentage = (marksEng + MarksMath + marksScience) / 3;
            return Percentage;
        }
        public void Display()
        {
            Console.WriteLine("Roll No : " + rollNo + "\nName : " + studName + "\nTotal Marks : " + (marksScience + marksMath + marksEng) + "\nPercentage : " + percentage + "%");
        }
    }
}
