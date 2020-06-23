using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCsharp
{
    class Question16
    {
        public static void Main()
        {
            string str;
            int a = 0;
            Console.Write("Input the word ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                a += 1;

            }

            Console.Write("Length is : {0}\n\n", a);
    }
    }
}
