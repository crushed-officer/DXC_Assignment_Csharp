using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCsharp
{
    class Question12
    {
        static void Main()
        {
            int i, sum = 0;

            Console.Write("Numbers between 100 and 200, divisible by 9 : \n");
            for (i = 200; i < 300; i++)
            {
                if (i % 7 == 0)
                {
                    
                    Console.Write(i + " ");
                    
                }
            }
          
        }

    }
}
