using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2AssignmentCsharp
{
    class CreditCard
    {
        private int months;
        private double totalAmount;
        private double balance;
        private double monthlyPayment;
        private double interest;

        public CreditCard()
        {
            /*Default Constructor*/
        }

        public double Interest { get => interest; set => interest = value; }
        public double MonthlyPayment { get => monthlyPayment; set => monthlyPayment = value; }
        public double Balance { get => balance; set => balance = value; }
        public double TotalAmount { get => totalAmount; set => totalAmount = value; }
        public int Months { get => months; set => months = value; }

        public void Payment()
        {
            for (int i = Months; TotalAmount >= 0; i++)
            {
                TotalAmount = Balance + (Balance * interest) / 100;
                TotalAmount -= MonthlyPayment;
                Balance = TotalAmount;
                Console.WriteLine("Month: " + i + " balance: " + TotalAmount + "total payments: " + i * MonthlyPayment);

            }
        }
    }
}
