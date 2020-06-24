using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2AssignmentCsharp
{
    class BookStoreMain
    {
        public static void Main()
        {
            BookStore b = new BookStore
            {
                Isbn = 11112222,
                BookName = "Playing XI",
                BookTitle = "Autobiograohy",
                BookAuthor = "Rajdeep Sardesai",
                QuantityOfBooks = 20,
                BookPrice = 200.0,

            };
            b.TotalPrice = b.CalculatePrice();
            b.DisplayDetails();
            b.BillingDetails();
            Console.ReadKey();
        }
    }
}
