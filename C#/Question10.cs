using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCsharp
{
    class Question10
    {
        static void Main()
        {
            Console.WriteLine("enter an integer");
            int a = 4;
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            if (n < a)
            {
                int b = n;
                n = a;
                a = b;
            }
            for(int i=a; i<=n;i++)
            {
                sum += i * i * i;

            }
            Console.WriteLine(sum);
        }
    }
}
