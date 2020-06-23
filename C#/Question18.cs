using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCsharp
{
    class Question18
    {
        public static void Main()
        {


            String string1 = Console.ReadLine();
            Console.WriteLine("Enter the first string: " + string1);
            String string2 = Console.ReadLine();
            Console.WriteLine("Enter the second string :" + string2);
            if (string1.Equals(string2) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
