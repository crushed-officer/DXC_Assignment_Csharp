using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCsharp
{
    class Quesstion3
    {
        static void Main(string[]args)
        {
            Console.WriteLine(" Enter the stating number");
            int start_no =int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the ending number");
            int end_no = int.Parse(Console.ReadLine());
            for (int i=start_no;i<end_no;i++)
            {
                Console.WriteLine(i);
            }
        }



    }
}
