﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCsharp
{
    class Question8
    {
        static void Main()
        {
            int i, fact = 1, number;
            Console.Write("Enter any Number ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact + " ");
        }
    }
}
