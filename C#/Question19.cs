using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCsharp
{
    class Question19
    {
        static void Main(string[] args)
        {
            string s, revs = "";
            Console.WriteLine(" Enter string");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--) 
            {
                revs += s[i].ToString();
            }
            if (revs == s)
                Console.WriteLine("Palindrome String {0}", revs);
            else
            {
                Console.WriteLine("String is not Palindrome {0}", revs);
            }
        }
    }
}
