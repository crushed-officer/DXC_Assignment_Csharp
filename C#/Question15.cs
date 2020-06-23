using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCsharp
{
    class Question15
    {
        public static void Main()
        {
            int[] a = new int[10];
            int i, n, max, min, sum = 0;
            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);

            double avg = sum / n;

            max = a[0];
            min = a[0];

            for (i = 1; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }


                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.Write("Maximum element is : {0}\n", max);
            Console.Write("Minimum element is : {0}\n\n", min);

            Array.Sort(a);
            Console.WriteLine("\nascending");
            for (int j = 0; j < a.Length; j++)
            {
                Console.Write(a[j] + " ");
            }

            Array.Reverse(a);
            Console.WriteLine("\nDescending");
            for (int j = 0; i < a.Length; j++)
            {
                Console.Write(a[j] + " ");
            }
        }

    }
}


