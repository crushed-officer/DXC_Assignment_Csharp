using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCsharp
{
    class Question17
    {
        static void Main(string[] args)
        {
            string str = "", reverse = "";
            int a = 0;
            Console.WriteLine("Enter a Word");  
            str = Console.ReadLine();
            str = str.ToLower();
            a = str.Length - 1;
            while (a >= 0)
            {
                reverse = reverse + str[a];
                a--;
            } 
            Console.WriteLine("Reverse is {0}", reverse);
            Console.ReadLine();
        }
    }
}
