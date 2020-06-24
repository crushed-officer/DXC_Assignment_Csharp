using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2AssignmentCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int month = 0;
            Console.WriteLine("Enter your monthly payment");
            double pay = double.Parse(Console.ReadLine());
            double left = 1000;
            double a = 0;
            double interest = 0.015;
            double balance = (left * interest) + left;
            double netbalance = (balance - pay);
            
            while (netbalance > 1)
            {
                double value = netbalance * .015;
                month++;
                a = a + pay;
                double total = a;

                netbalance = (value + netbalance) - pay;
                Console.WriteLine("Month: " + month + " Balance: " + netbalance + " Total Payments: " + total );
            }
        }
    }
}
