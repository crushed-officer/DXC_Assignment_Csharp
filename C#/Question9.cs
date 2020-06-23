using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCsharp
{
    class Question9
    {
        static void Main(string[] args)
        {
            int i, count, a = 0, b = 1, c = 0;
            Console.Write("Enter the Limit ");
            count = 40;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (i = 0; i <= count; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
